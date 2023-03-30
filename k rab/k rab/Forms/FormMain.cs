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
        internal bool sideLengthVis;
        SolidBrush brush = new SolidBrush(Color.Black);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var shape in _shapes)
                shape.Draw(e.Graphics, brush);
        }

        public FormMain()
        {
            InitializeComponent();
            /*var shapes = typeof(Shape).Assembly
                .GetTypes()
                .Where(f => f.IsSubclassOf(typeof(Shape)))
                .ToArray();
            var constructors = shapes.Select(t => t.GetConstructors()[0]).ToArray();
            var l = new Label();
            l.Parent = this;
            l.Location = new Point(100, 100);
            l.Size = new Size(200, 200);
            l.Text = constructors[0].GetParameters()[0].Name;
            l.Show();
            l.BringToFront();*/
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            panel1.Invalidate();
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
    }
}
