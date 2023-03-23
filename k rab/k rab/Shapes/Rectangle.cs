using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    internal class Rectangle : Shape
    {
        private Color _color;
        private int width;
        private int height;
        private int xCord;
        private int yCord;

        public Rectangle(int width, int height, int x, int y)
        {
            this.width = width;
            this.height = height;
            x = xCord;
            y = yCord;
        }

        public override float GetArea()
        {
           return width * height;
        }

        public override void Draw(Graphics g, SolidBrush brush)
        {
            throw new NotImplementedException();
        }

    }
}
