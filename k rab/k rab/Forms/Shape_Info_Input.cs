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
        internal bool _sideLengthVis;
        public Shape_Info_Input(bool sideLengthVis)
        {
            _sideLengthVis = sideLengthVis;
            InitializeComponent();
        }
        private void Submit_InfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void WidthValLabel_Click(object sender, EventArgs e)
        {

        }
        private void WidthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeightValLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SideLengthLabel_Click(object sender, EventArgs e)
        {
            SideLengthLabel.Visible = _sideLengthVis;
        }

        private void SideLengthBox_TextChanged(object sender, EventArgs e)
        {
            if(!_sideLengthVis)
                SideLengthBox.Visible = false;
        }
    }
}
