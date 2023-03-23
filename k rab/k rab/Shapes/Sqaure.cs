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
        private int sideLength;
        private int xCord;
        private int yCord;
        private Color _color;
        
        public Square(int sideLength, int x, int y)
        {
            this.sideLength = sideLength;
            xCord = x;
            yCord = y;
        }

        public override float GetArea()
        {
           return sideLength * sideLength;
        }

        public override void Draw(Graphics g, SolidBrush brush)
        {
             throw new NotImplementedException();
        }

    }
}
