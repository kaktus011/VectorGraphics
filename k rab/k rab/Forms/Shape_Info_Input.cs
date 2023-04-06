using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace k_rab.Forms
{
    public partial class Shape_Info_Input : Form
    {
        private readonly bool _isOneSided;
        private readonly bool _isEditing;
        public int X { get; private set; }
        public int Y { get; private set; }
        public int ShapeSide { get; private set; }
        public int ShapeHeight { get; private set; }
        public int ShapeWidth { get; private set; }
        
        private Shape_Info_Input(bool isOneSided, bool edit)
        {
            _isOneSided = isOneSided;
            _isEditing = edit;
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

        public static Shape_Info_Input FromOneSide(bool edit)
        {
            Shape_Info_Input info = new Shape_Info_Input(false, edit);
            info.ShowDialog();
            return info;
        }

        public static Shape_Info_Input FromTwoSides(bool edit)
        {
            Shape_Info_Input info = new Shape_Info_Input(true, edit);
            info.ShowDialog();
            return info;
        }

        private void Shape_Info_Input_Load_1(object sender, EventArgs e)
        {
            xValLabel.Visible = !_isEditing;
            xValBox.Visible = xValLabel.Visible;

            yValLabel.Visible = !_isEditing;
            yValBox.Visible = yValLabel.Visible;

            SideLengthLabel.Visible = _isOneSided;
            SideLengthBox.Visible = SideLengthLabel.Visible;

            widthValLabel.Visible = !_isOneSided;
            WidthBox.Visible = widthValLabel.Visible;

            heightValLabel.Visible = !_isOneSided;
            HeightBox.Visible = heightValLabel.Visible;
        }

        private void Submit_InfoBtn_Click(object sender, EventArgs e)
        {
            if(!_isEditing)
            {
                X = int.Parse(xValBox.Text);
                Y = int.Parse(yValBox.Text);
            }

            if (_isOneSided)
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