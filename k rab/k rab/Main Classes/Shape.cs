using k_rab.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    abstract class Shape : IDrawable
    {
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsSelected { get; set; }
        public abstract float GetArea();
        public abstract void Draw(Graphics g, SolidBrush brush, Pen pen);

        public virtual bool IsPointInside(Point point) =>
            point.X >= X &&
            point.Y >= Y;
        public Point GetOffset(Point point) => new Point(point.X - X, point.Y - Y);

        public Shape(Shape_Info_Input info) : this(info.X, info.Y) { }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
