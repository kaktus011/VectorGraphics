using k_rab.Forms;
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
        internal int _width;
        internal int _height;

        public Elipse(Shape_Info_Input info) : base(info)
        {
            _width = info._width;
            _height = info._height;
        }

        public Elipse(int x, int y, int width, int height) : base(x, y)
        {
            _width = width;
            _height = height;
        }

        
        public override float GetArea()
        {
            if(_width == _height)// if shape is Circle
                return (float)(Math.PI * _width * _width);
            else
                return (float)(Math.PI * _width * _height);
        }

        public override void Draw(Graphics g, SolidBrush brush)
        {
            g.FillEllipse(brush, X, Y, _width, _height);
        }

    }
}
