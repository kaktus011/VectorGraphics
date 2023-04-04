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
        private int _width;
        private int _height;

        public Elipse(Shape_Info_Input info) : base(info)
        {
            _width = info.ShapeWidth;
            _height = info.ShapeHeight;
        }

        public Elipse(int x, int y, int width, int height) : base(x, y)
        {
            _width = width;
            _height = height;
        }
        public override float GetArea()
        {
            return (float)(Math.PI * _width * _height);
        }

        public override void Draw(Graphics g, SolidBrush brush, Pen pen)
        {
            brush.Color = Color;
            pen.Color = BorderColor;
            g.FillEllipse(brush, X, Y, _width, _height);
            g.DrawEllipse(pen, X, Y, _width, _height);
            if (!IsSelected) return;

            pen.Color = Color.Pink;
            g.DrawEllipse(pen, X, Y, _width, _height);

        }
        public override bool IsPointInside(Point point)
        {
            Point center = new Point((X + X+_width) / 2,
                                     (Y + Y+_height) / 2);

            if (_width == _height)//cirlce
            {
                int d = (point.X - center.X)*(point.X - center.X)
                      + (point.Y - center.Y)*(point.Y - center.Y);
                return d <= (_width/2) * (_height/2);
            }

            else//elipse
            { 
                double xRadius = _width/2.0;
                double yRadius = _height/2.0;

                double d = ((double)Math.Pow((point.X - center.X), 2)
                   / (double)Math.Pow(xRadius, 2))
                  + ((double)Math.Pow((point.Y - center.Y), 2)
                     / (double)Math.Pow(yRadius, 2));

                return d <= 1;
            }
        }
    }
}
