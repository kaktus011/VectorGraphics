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

        public override void Draw(Graphics g, SolidBrush brush)
        {
            g.FillEllipse(brush, X, Y, _width, _height);
        }
        public override bool IsPointInside(Point point)
        {
            return base.IsPointInside(point) &&
                   point.X <= X + _width &&
                   point.Y <= Y + _height;
            //tova ne raboti
            //ako e krug opredeli dali lokaciqta na mihskata e vuv kruga 
            //if (_width == _height)
            //{
            //    Point center = new Point((X + point.X) / 2, 
            //                             (Y + point.Y) / 2);
            //    int d = (point.X - center.X)*(point.X - center.X)
            //            + (point.Y - center.Y)*(point.Y - center.Y);
            //    return d <= _width * _height;
            //}
            //else
            //{
            //    return base.IsPointInside(point) &&
            //           point.X <= X + _width &&
            //           point.Y <= Y + _height;
            //}
        }
    }
}
