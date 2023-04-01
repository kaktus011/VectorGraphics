using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace k_rab.Forms
{
    public partial class Shape_Info_Input : Form
    {
        private bool _sideLengthVis;
        //public string Shape { get; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int ShapeSide { get; private set; }
        public int ShapeHeight { get; private set; }
        public int ShapeWidth { get; private set; }
        
        public Shape_Info_Input(bool sideLengthVis)
        {
            _sideLengthVis = sideLengthVis;
            InitializeComponent();
            //var shapes = typeof(Shape).Assembly
            //    .GetTypes()
            //    .Where(f => f.IsSubclassOf(typeof(Shape)))
            //    .ToArray();
            //var constructors = shapes.Select(t => t.GetConstructors()[1]).ToArray();
            //var l = new Label();
            //l.Parent = this;
            //l.Location = new Point(456, 125);
            //l.Size = new Size(152, 46);
            //l.Text = constructors[0].GetParameters()[2].Name;
            //l.Show();
            //l.BringToFront();
        }
        private void Shape_Info_Input_Load_1(object sender, EventArgs e)
        {
            SideLengthLabel.Visible = _sideLengthVis;
            SideLengthBox.Visible = _sideLengthVis;
            widthValLabel.Visible = !_sideLengthVis;
            WidthBox.Visible = !_sideLengthVis;
            HeightBox.Visible = !_sideLengthVis;
            heightValLabel.Visible = !_sideLengthVis;
        }

        private void Submit_InfoBtn_Click(object sender, EventArgs e)
        {
            X = int.Parse(xValBox.Text);
            Y = int.Parse(yValBox.Text);
            if (_sideLengthVis)
            {
                ShapeSide = int.Parse(SideLengthBox.Text);
            }
            else
            {
                ShapeHeight = int.Parse(HeightBox.Text);
                ShapeWidth = int.Parse(WidthBox.Text);
            }
            Close();
        }
    }
}
