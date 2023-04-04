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
    internal class Triangle : Shape
    {
        private int sideLength;
        private Point p1;
        private Point p2;
        private Point p3;
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

        public override void Draw(Graphics g, SolidBrush brush, Pen pen)
        {
            p1 = new Point(X, Y);
            p2 = new Point(X + sideLength, Y);
            p3 = new Point(X + sideLength / 2, Y - (int)(sideLength * Math.Sin(Math.PI / 3)));

            Point[] points ={ p1, p2, p3 };

            brush.Color = Color;
            pen.Color = BorderColor;
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
            if (!IsSelected) return;

            pen.Color = Color.Pink;
            g.DrawPolygon(pen, points);
        }
        public override void EditShape()
        {
            Shape_Info_Input info = Shape_Info_Input.FromTwoSides(true);
            sideLength = info.ShapeSide;
        }
        public override bool IsPointInside(Point point)
        {
            double A = area(p1.X, p1.Y, p2.X, p2.Y, p3.X, p3.Y);
            double A1 = area(point.X, point.Y, p2.X, p2.Y, p3.X, p3.Y);
            double A2 = area(p1.X, p1.Y, point.X, point.Y, p3.X, p3.Y);
            double A3 = area(p1.X, p1.Y, p2.X, p2.Y, point.X, point.Y);

            return (A == A1 + A2 + A3);
        }
        static double area(int x1, int y1, int x2, int y2, int x3, int y3) =>
            Math.Abs((x1 * (y2 - y3) +
                      x2 * (y3 - y1) +
                      x3 * (y1 - y2)) / 2.0);

    }
}
