using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_rab.Forms
{
    public partial class Shape_Info_Input : Form
    {
        private bool _sideLengthVis;
        public int _X;
        public int _Y;
        public int _Side;
        public int _Height;
        public int _Width;
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
            _Side = int.Parse(SideLengthBox.Text);
            _Height = int.Parse(HeightBox.Text);
            _Width = int.Parse(WidthBox.Text);
            //tezi parametri ne se podavat vse oshte kum glavnata
            //forma za da se suzdade figura s tqh
        }

    }
}
