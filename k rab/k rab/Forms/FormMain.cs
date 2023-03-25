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
        private List<IDrawable> _shapes = new List<IDrawable>();
        public bool sideLengthVis = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SolidBrush brush = new SolidBrush(Color.Black);
            foreach (var shape in _shapes)
                shape.Draw(e.Graphics, brush);
        }
        /*protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            switch (e.KeyCode)
            {
                case Keys.R:
                    _shapes.Add(new Rectangle(100, 100, 150, 100));
                    break;
                case Keys.S:
                    _shapes.Add(new Square(100, 100, 150));
                    break;
                case Keys.C:
                    _shapes.Add(new Elipse(100, 100, 50, 50));
                    break;
                case Keys.T:
                    _shapes.Add(new Triangle(100, 100, 125));
                    break;
            }
            Refresh();
        }*/
        public FormMain()
        {
            InitializeComponent();
        }

        private void ElipseBtn_Click(object sender, EventArgs e)
        {
            sideLengthVis = false;
            Shape_Info_Input shape_Input = new Shape_Info_Input(sideLengthVis);
            shape_Input.Show();
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            Shape_Info_Input shape_Input = new Shape_Info_Input(sideLengthVis);
            shape_Input.Show();
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            Shape_Info_Input shape_Input = new Shape_Info_Input(sideLengthVis);
            shape_Input.Show();
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            sideLengthVis = false;
            Shape_Info_Input shape_Input = new Shape_Info_Input(sideLengthVis);
            shape_Input.Show();
        }
    }
}
