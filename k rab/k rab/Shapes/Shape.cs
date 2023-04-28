using k_rab.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    [Serializable]
    public abstract class Shape : IDrawable
    {
        public Color Color { get; set; } = Color.Black;
        public Color BorderColor { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public Shape(Shape_Info_Input info) : this(info.X, info.Y) { }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract bool CanUndo { get; }
        public abstract bool CanRedo { get; }

        public bool IsSelected { get; set; }

        public abstract void UndoStackPush(Shape shape);
        public abstract void RedoStackPush(Shape shape);
        public abstract Shape UndoStackPop();
        public abstract Shape RedoStackPop();
        public abstract void RedoClear();

        public abstract double GetArea();
        public abstract void Draw(Graphics g, SolidBrush brush, Pen pen);
        public abstract void EditShape();
        public abstract Shape GetCopy();

        public virtual bool IsPointInside(Point point) =>
            point.X >= X &&
            point.Y >= Y;

        public double DistanceBetweenPoints(Point p1, Point p2)
            => Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));

        public Point GetOffset(Point point) => new Point(point.X - X, point.Y - Y);

    }
}
