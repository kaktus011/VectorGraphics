using k_rab.Forms;
using k_rab.Shapes;
using kursovaLibrary;
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
        private readonly List<Shape> _shapes = new List<Shape>();
        private readonly List<Shape> _shapesCopy = new List<Shape>();

        private readonly SolidBrush _brush = new SolidBrush(Color.Black);
        private readonly Pen _pen = new Pen(Color.Pink, 5);
        private Shape _selectedShape;
        private Shape _lastSelectedShape;
        private Point _offset;
        private readonly StateTracker _state = new StateTracker();
        private bool _deleted;

        public FormMain()
        {
            InitializeComponent();
            DoubleBufferedPanel1.Refresh();
        }
        
        private void DoubleBufferedPanel1_Paint(object sender, PaintEventArgs e)
        {
            var drawables = _shapes.Where(s => s != null).ToList();
            foreach (Shape shape in drawables)
                shape.Draw(e.Graphics, _brush, _pen);
            DisplaySelectedShapeArea();
        }

        private void DoubleBufferedPanel1_MouseDown(object sender, MouseEventArgs e)
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

                    if(_lastSelectedShape != null && _lastSelectedShape.IsSelected == true)
                    {
                        _lastSelectedShape.IsSelected = false;
                        DoubleBufferedPanel1.Refresh();
                    }

                    _selectedShape = _shapes[i];
                    _shapes[i] = _shapes[_shapes.Count - 1];
                    _shapes[_shapes.Count - 1] = _selectedShape;

                    _lastSelectedShape = _selectedShape;
                    _offset = _selectedShape.GetOffset(e.Location);
                    _lastSelectedShape.IsSelected = true;

                    _state.AddNewState(_lastSelectedShape, false);

                    break;
                }
            }
        }

        private void DoubleBufferedPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            
            MoveSelected(e.Location);
        }

        private void DoubleBufferedPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_selectedShape == null) return;

            MoveSelected(e.Location);
            _lastSelectedShape.IsSelected = false;
            _selectedShape = null;
        }

        private void ElipseBtn_Click(object sender, EventArgs e)
        { 
            _shapes.Add(new Elipse(Shape_Info_Input.FromOneSide(false)));
            DoubleBufferedPanel1.Refresh();
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            _shapes.Add(new Triangle(Shape_Info_Input.FromTwoSides(false)));
            DoubleBufferedPanel1.Refresh();
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            _shapes.Add(new Square(Shape_Info_Input.FromTwoSides(false)));
            DoubleBufferedPanel1.Refresh();
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            _shapes.Add(new Rectangle(Shape_Info_Input.FromOneSide(false)));
            DoubleBufferedPanel1.Refresh();
        }

        private void ConeBtn_Click(object sender, EventArgs e)
        {
            _shapes.Add(new Cone(Shape_Info_Input.FromOneSide(false)));
            DoubleBufferedPanel1.Refresh();
        }

        private void DeleteShapeBtn_Click(object sender, EventArgs e)
        {
            if(_lastSelectedShape == null) return;

            _deleted = true;
            _state.AddNewState(_lastSelectedShape, false);
            _shapes.Remove(_lastSelectedShape);
            _lastSelectedShape.IsSelected = false;

            DoubleBufferedPanel1.Refresh();
        }

        private void ChangeColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK && _lastSelectedShape != null)
            {
                _state.AddNewState(_lastSelectedShape, false);
                _lastSelectedShape.Color = cd.Color;
                DoubleBufferedPanel1.Refresh();
            }
        }

        private void BorderColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK && _lastSelectedShape != null)
            {
                _state.AddNewState(_lastSelectedShape, false);
                _lastSelectedShape.BorderColor = cd.Color;
                DoubleBufferedPanel1.Refresh();
            }
        }

        private void EditShapeBtn_Click(object sender, EventArgs e)
        {
            if (_lastSelectedShape == null) return;

            _state.AddNewState(_lastSelectedShape, false);
            _lastSelectedShape.EditShape();
            _shapes.Remove(_lastSelectedShape);
            _shapes.Add(_lastSelectedShape);
            DoubleBufferedPanel1.Refresh();
        }

        private void LargestShapeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (_shapes.Count == 0) return;

            foreach(Shape shape in _shapes)
                _shapesCopy.Add(shape);
            Shape biggestShape = _shapes.OrderByDescending(shape => shape.GetArea()).First();

            _shapes.Clear();
            _shapes.Add(biggestShape);
            if (_lastSelectedShape ==  biggestShape)
                biggestShape.IsSelected = true;

            DoubleBufferedPanel1.Refresh();
        }

        private void LargestShapeBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if(_shapesCopy.Count == 0) return;

            _shapes.Clear();
            foreach (Shape shape in _shapesCopy)
            {
                _shapes.Add(shape);
                if (shape ==  _lastSelectedShape)
                {
                    _lastSelectedShape = shape;
                    _lastSelectedShape.IsSelected = true;
                }
            }
            _shapesCopy.Clear();
            
            DoubleBufferedPanel1.Refresh();
        }
        
        private void ClosestToCenterBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (_shapes.Count == 0) return;

            foreach (Shape shape in _shapes)
                _shapesCopy.Add(shape);

            int centerX = DoubleBufferedPanel1.ClientSize.Width / 2;
            int centerY = DoubleBufferedPanel1.ClientSize.Height / 2;
            Point center = new Point(centerX, centerY);

            Shape closest = _shapes.OrderBy(shape => 
                    shape.DistanceBetweenPoints(new Point(shape.X, shape.Y), center)).First();

            _shapes.Clear();
            _shapes.Add(closest);
            if(_lastSelectedShape == closest)
                closest.IsSelected = true;

            DoubleBufferedPanel1.Refresh();
        }

        private void ClosestToCenterBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (_shapesCopy.Count == 0) return;

            _shapes.Clear();
            foreach (Shape shape in _shapesCopy)
            {
                _shapes.Add(shape);
                if (shape ==  _lastSelectedShape)
                {
                    _lastSelectedShape = shape;
                    _lastSelectedShape.IsSelected = true;
                }
            }
            _shapesCopy.Clear();

            DoubleBufferedPanel1.Refresh();
        }
        private void SmallestEvenAreaBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (_shapes.Count == 0) return;

            foreach (Shape shape in _shapes)
                _shapesCopy.Add(shape);
            Shape biggestShape = _shapes.OrderByDescending(shape => shape.GetArea() % 2 == 0)
                                        .ThenBy(shape => shape.GetArea()).First();

            _shapes.Clear();
            _shapes.Add(biggestShape);
            if (_lastSelectedShape ==  biggestShape)
                biggestShape.IsSelected = true;

            DoubleBufferedPanel1.Refresh();
        }

        private void SmallestEvenAreaBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (_shapesCopy.Count == 0) return;

            _shapes.Clear();
            foreach (Shape shape in _shapesCopy)
            {
                _shapes.Add(shape);
                if (shape ==  _lastSelectedShape)
                {
                    _lastSelectedShape = shape;
                    _lastSelectedShape.IsSelected = true;
                }
            }
            _shapesCopy.Clear();

            DoubleBufferedPanel1.Refresh();
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if(_lastSelectedShape == null || !_lastSelectedShape.CanUndo) return;

            _shapes.Remove(_lastSelectedShape);
            _lastSelectedShape = _state.Undo(_lastSelectedShape);
            _lastSelectedShape.IsSelected = true;
            _shapes.Add(_lastSelectedShape);

            DoubleBufferedPanel1.Refresh();
        }

        private void RedoBtn_Click(object sender, EventArgs e)
        {
            if (_lastSelectedShape == null || !_lastSelectedShape.CanRedo) return;

            if (_deleted)
            {
                _shapes.Remove(_lastSelectedShape);
                _state.AddNewState(_lastSelectedShape, true);
                _deleted = false;

                DoubleBufferedPanel1.Refresh();
            }

            else
            {
                _shapes.Remove(_lastSelectedShape);
                _lastSelectedShape = _state.Redo(_lastSelectedShape);
                _shapes.Add(_lastSelectedShape);

                DoubleBufferedPanel1.Refresh();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Shape Files (*.shape)|*.shape";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<Shape> shapeInfos = new List<Shape>();

                    foreach (Shape shape in _shapes)
                        shapeInfos.Add(shape);

                    using (FileStream fileStream = new FileStream
                            (saveFileDialog.FileName, FileMode.Create))
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
                openFileDialog.Filter = "Shape Files (*.shape)|*.shape";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _shapes.Clear();
                    using (FileStream fileStream = new FileStream
                            (openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        List<Shape> shapeInfos = (List<Shape>)binaryFormatter
                                                        .Deserialize(fileStream);

                        foreach(Shape shape in shapeInfos)
                            _shapes.Add(shape);

                        shapeInfos.Clear();
                    }
                }
            }
            _lastSelectedShape = null;
            DoubleBufferedPanel1.Refresh();
        }

        private void MoveSelected(Point point)
        {
            if (_selectedShape == null) return;

            _selectedShape.X = point.X - _offset.X;
            _selectedShape.Y = point.Y - _offset.Y;
            DoubleBufferedPanel1.Refresh();
        }

        private void DisplaySelectedShapeArea()
        {
            if (_lastSelectedShape == null || _lastSelectedShape.IsSelected == false)
                AreaLabel.Text = "No shape selected";
            else
                AreaLabel.Text = _lastSelectedShape.GetArea().ToString() + " cm";
        }
    }

    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel() => DoubleBuffered = true;
    }

}