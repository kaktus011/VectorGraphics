using k_rab.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_rab
{
    internal class Square : Shape
    {
        private Color _color;
        private int sideLength;

        public Square(Shape_Info_Input info) : base(info)
        {
            sideLength = info._Side;
        }

        public Square(int x, int y, int side) : base(x, y)
        {
            sideLength = side;
        }

        public override float GetArea()
        {
           return sideLength * sideLength;
        }

        public override void Draw(Graphics g, SolidBrush brush)
        {
            g.FillRectangle(brush, X, Y, sideLength, sideLength);
        }

    }
}
