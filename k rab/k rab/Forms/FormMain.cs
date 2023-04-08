using k_rab.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace k_rab
{
    public partial class FormMain : Form
    {
        private readonly List<IDrawable> _shapes = new List<IDrawable>();

        private readonly Stack<Shape> undoStack = new Stack<Shape>();
        private readonly Stack<Shape> redoStack = new Stack<Shape>();

        private readonly SolidBrush _brush = new SolidBrush(Color.Black);
        private readonly Pen _pen = new Pen(Color.Pink, 5);
        private Shape _selectedShape;
        private Shape _shapeForEditing;
        private Point _offset;

        public FormMain()
        {
            InitializeComponent();
            //var shapes = typeof(Shape).Assembly
            //    .GetTypes()
            //    .Where(f => f.IsSubclassOf(typeof(Shape)))
            //    .ToArray();
            //var constructorNames = shapes.Select(f => f.Name).ToArray();

            //var buttons = new List<Button>();
            //foreach (var name in constructorNames)
            //    buttons.Add(new Button());


            //var btn = new Button();
            //btn.Parent = this;
            //btn.Location = new Point(158, 12);
            //btn.Size = new Size(193, 67);
            //btn.Text = constructorNames[0];
            //btn.Show();
            //btn.BringToFront();
            //label.Font.Size = new Size(158, 12);
            //var constructors = shapes.Select(t => t.GetConstructors()[1]).ToArray();
            //var l = new Label();
            //l.Parent = this;
            //l.Location = new Point(100, 100);
            //l.Size = new Size(200, 200);
            //l.Text = constructors[0].GetParameters()[0].Name;
            //l.Show();
            //l.BringToFront();
        }

        private void doubleBufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in _shapes)
                shape.Draw(e.Graphics, _brush, _pen);
            DisplaySelectedShapeArea();
        }

        private void doubleBufferedPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                for (int i = _shapes.Count - 1; i >= 0; --i)
                {
                    if (!_shapes[i].IsPointInside(e.Location))
                    {
                        _selectedShape = null;
                        continue;
                    }

                    _selectedShape = (Shape)_shapes[i];
                    _shapeForEditing = _selectedShape;
                    _offset = _selectedShape.GetOffset(e.Location);
                    _selectedShape.IsSelected = true;
                    _shapes[i] = _shapes[_shapes.Count - 1];
                    _shapes[_shapes.Count - 1] = _selectedShape;
                    undoStack.Push(_selectedShape.GetCopy());
                    if (redoStack.Count > 0)
                    {
                        //undoStack.Push(redoStack.Pop());
                        redoStack.Clear();
                    }

                    break;
                }
            }
        }

        private void doubleBufferedPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            
            MoveSelected(e.Location);
        }

        private void doubleBufferedPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_selectedShape == null) return;

            MoveSelected(e.Location);
            _selectedShape.IsSelected = false;
            _selectedShape = null;
        }

        private void ElipseBtn_Click(object sender, EventArgs e)
        { 
            _shapes.Add(new Elipse(Shape_Info_Input.FromOneSide(false)));
            doubleBufferedPanel1.Refresh();
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            _shapes.Add(new Triangle(Shape_Info_Input.FromTwoSides(false)));
            doubleBufferedPanel1.Refresh();
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            _shapes.Add(new Square(Shape_Info_Input.FromTwoSides(false)));
            doubleBufferedPanel1.Refresh();
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            _shapes.Add(new Rectangle(Shape_Info_Input.FromOneSide(false)));
            doubleBufferedPanel1.Refresh();
        }

        private void DeleteShapeBtn_Click(object sender, EventArgs e)
        {
            if(_shapeForEditing == null) return;

            undoStack.Push(_shapeForEditing);
            if (redoStack.Count > 0)
            {
                //undoStack.Push(redoStack.Pop());
                redoStack.Clear();
            }
            _shapes.Remove(_shapeForEditing);
            doubleBufferedPanel1.Refresh();
        }

        private void ChangeColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK && _shapeForEditing != null)
            {
                undoStack.Push(_shapeForEditing.GetCopy());
                if (redoStack.Count > 0)
                {
                    //undoStack.Push(redoStack.Pop());
                    redoStack.Clear();
                }
                _shapeForEditing.Color = cd.Color;
                doubleBufferedPanel1.Refresh();
            }
        }

        private void BorderColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK && _shapeForEditing != null)
            {
                undoStack.Push(_shapeForEditing.GetCopy());
                if (redoStack.Count > 0)
                {
                    //undoStack.Push(redoStack.Pop());
                    redoStack.Clear();
                }
                _shapeForEditing.BorderColor = cd.Color;
                doubleBufferedPanel1.Refresh();
            }
        }

        private void EditShapeBtn_Click(object sender, EventArgs e)
        {
            if (_shapeForEditing == null) return;

            undoStack.Push(_shapeForEditing.GetCopy());
            if (redoStack.Count > 0)
            {
                //undoStack.Push(redoStack.Pop());
                redoStack.Clear();
            }
            _shapeForEditing.EditShape();
            _shapes[_shapes.Count - 1] = _shapeForEditing;
            doubleBufferedPanel1.Refresh();
        }

        private void MoveSelected(Point point)
        {
            if (_selectedShape == null) return;

            _selectedShape.X = point.X - _offset.X;
            _selectedShape.Y = point.Y - _offset.Y;
            doubleBufferedPanel1.Refresh();
        }

        private void DisplaySelectedShapeArea()
        {
            if (_selectedShape == null)
                AreaLabel.Text = "No shape selected";
            else
                AreaLabel.Text = _selectedShape.GetArea().ToString() + " cm";
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if(undoStack.Count == 0) return;

            _shapes.Remove(_shapeForEditing);
            redoStack.Push(_shapeForEditing.GetCopy());
            _shapeForEditing = undoStack.Pop();
            _shapes.Add(_shapeForEditing);
            doubleBufferedPanel1.Refresh();
        }

        private void RedoBtn_Click(object sender, EventArgs e)
        {
            if (redoStack.Count == 0) return;

            _shapes.Remove(_shapeForEditing);
            _shapeForEditing = redoStack.Pop();
            _shapes.Add(_shapeForEditing);
            undoStack.Push(_shapeForEditing.GetCopy());
            doubleBufferedPanel1.Refresh();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Shape Files (*.shape)|*.shape|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<Shape> shapeInfos = new List<Shape>();

                    foreach(Shape shape in _shapes)
                        shapeInfos.Add(shape.GetCopy());

                    using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(fileStream, shapeInfos);
                    }
                }
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Shape Files (*.shape)|*.shape|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _shapes.Clear();
                    using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        List<Shape> shapeInfos = (List<Shape>)binaryFormatter.Deserialize(fileStream);

                        foreach(Shape shape in shapeInfos)
                        {
                            _shapes.Add(shape);
                        }
                        shapeInfos.Clear();
                    }
                }
            }
            doubleBufferedPanel1.Refresh();
        }
    }
    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel() => DoubleBuffered = true;
    }

}