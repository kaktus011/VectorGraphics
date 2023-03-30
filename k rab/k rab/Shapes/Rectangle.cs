using k_rab.Forms;
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
        private int _width;
        private int _height;


        public Rectangle(Shape_Info_Input info) : base(info)
        {
            _width = info._width;
            _height = info._height;
        }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            _width = width;
            _height = height;
        }

        public override float GetArea()
        {
           return _width * _height;
        }

        public override void Draw(Graphics g, SolidBrush brush)
        {
            g.FillRectangle(brush, X, Y, _width, _height);
        }

    }
}
