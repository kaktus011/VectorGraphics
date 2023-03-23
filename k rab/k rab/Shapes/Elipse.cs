using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    internal class Elipse : Shape
    {
        private Color _color;
        private int radius;
        private int xCord;
        private int yCord;

        public Elipse(int radius, int x, int y)
        {
            this.radius = radius;
            x = xCord;
            y = yCord;
        }

        public override float GetArea()
        {
            return (float)(Math.PI * radius * radius);
        }

        public override void Draw(Graphics g, SolidBrush brush)
        {
            throw new NotImplementedException();
        }

    }
}
