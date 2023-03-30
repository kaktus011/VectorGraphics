using System;
using System.Windows.Forms;

namespace k_rab.Forms
{
    public partial class Shape_Info_Input : Form
    {
        private bool _sideLengthVis;
        //public string Shape { get; }
        internal int _X;
        internal int _Y;
        internal int _Side;
        internal int _height;
        internal int _width;
        
        public Shape_Info_Input(bool sideLengthVis)
        {
            _sideLengthVis = sideLengthVis;
            InitializeComponent();
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
            _X = int.Parse(xValBox.Text);
            _Y = int.Parse(yValBox.Text);
            if (_sideLengthVis)
            {
                _Side = int.Parse(SideLengthBox.Text);
            }
            else
            {
                _height = int.Parse(HeightBox.Text);
                _width = int.Parse(WidthBox.Text);
            }
            Close();
        }
    }
}
