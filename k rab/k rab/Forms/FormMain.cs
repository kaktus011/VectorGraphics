using k_rab.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_rab
{
    public partial class FormMain : Form
    {
        private readonly List<IDrawable> _shapes = new List<IDrawable>();
        private bool sideLengthVis { get; set; }
        private Shape _selectedShape;
        private Point _offset;
        SolidBrush brush = new SolidBrush(Color.Black);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in _shapes)
                shape.Draw(e.Graphics, brush);
        }

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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            panel1.Refresh();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                foreach (var shape in _shapes)
                {
                    if (shape.IsPointInside(e.Location))
                    {
                        _selectedShape = (Shape)shape;
                        _offset = _selectedShape.GetOffset(e.Location);
                        _selectedShape.IsSelected = true;
                        break;
                    }
                }
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            MoveSelected(e.Location);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_selectedShape == null) return;
            MoveSelected(e.Location);
            _selectedShape.IsSelected = false;
            _selectedShape = null;
        }
        private void ElipseBtn_Click(object sender, EventArgs e)
        {
            sideLengthVis = false;
            Shape_Info_Input info = new Shape_Info_Input(sideLengthVis);
            info.ShowDialog();
            _shapes.Add(new Elipse(info));
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            sideLengthVis = true;
            Shape_Info_Input info = new Shape_Info_Input(sideLengthVis);
            info.ShowDialog();
            _shapes.Add(new Triangle(info));
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            sideLengthVis = true;
            Shape_Info_Input info = new Shape_Info_Input(sideLengthVis);
            info.ShowDialog();
            _shapes.Add(new Square(info));

        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            sideLengthVis = false;
            Shape_Info_Input info = new Shape_Info_Input(sideLengthVis);
            info.ShowDialog();
            _shapes.Add(new Rectangle(info));
        }
        private void MoveSelected(Point point)
        {
            if (_selectedShape == null) return;
            _selectedShape.X = point.X - _offset.X;
            _selectedShape.Y = point.Y - _offset.Y;
        }

    } 
}
