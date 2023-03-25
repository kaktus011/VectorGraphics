using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    internal class Triangle : Shape
    {
        private Color _color;
        private int _size;
        private int _x;
        private int _y;
        public Triangle(int x, int y, int size)
        {
            _size = size;
            _x = x;
            _y = y;
        }

        public override float GetArea()
        {
            return (float)(_size * 1.732 * 0.25);
        }

        public override void Draw(Graphics g, SolidBrush brush)
        {
            throw new NotImplementedException();
        }

    }
}
