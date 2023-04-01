using k_rab.Forms;
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
        private int sideLength;
        public Triangle(Shape_Info_Input info) : base(info)
        {
            sideLength = info.ShapeSide;
        }
        public Triangle(int x, int y, int size): base(x, y)
        {
            sideLength = size;
        }

        public override float GetArea()
        {
            return (float)(sideLength * 1.732 * 0.25);
        }

        public override void Draw(Graphics g, SolidBrush brush)
        {
            Point[] points =
            {
                new Point(X, Y),
                new Point(X + sideLength, Y),
                new Point(X + sideLength / 2, Y - (int)(sideLength * Math.Sin(Math.PI / 3)))
            };
            g.FillPolygon(brush, points);
        }
    }
}
