using k_rab.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace k_rab.Shapes
{
    [Serializable]
    internal class Cone : Shape
    {
        private readonly Stack<Shape> undoStack = new Stack<Shape>();
        private readonly Stack<Shape> redoStack = new Stack<Shape>();

        private int _width;//width of the base
        private int _height;//height from the center of the base to the top of the triangle
        private Point p1;
        private Point p2;
        private Point p3;

        public override bool CanUndo => undoStack.Count > 0;
        public override bool CanRedo => redoStack.Count > 0;

        public Cone(Shape_Info_Input info) : base(info)
        {
            _width = info.ShapeWidth;
            _height = info.ShapeHeight;
        }

        public Cone(int x, int y, int width, int height,
                      Color color, Color borderColor, Stack<Shape> undo, Stack<Shape> redo)
                      : base(x, y)
        {
            _width = width;
            _height = height;
            Color = color;
            BorderColor = borderColor;
            undoStack = undo;
            redoStack = redo;
        }

        public override void Draw(Graphics g, SolidBrush brush, Pen pen)
        {
            brush.Color = Color;
            pen.Color = BorderColor;


            p1 = new Point(X, Y);
            p2 = new Point(X + _width, Y);
            p3 = new Point(X + _width / 2, Y - _height);

            Point[] points = { p1, p2, p3 };

            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);

            g.FillEllipse(brush, X, Y - _width / 9, _width, _width / 4);
            g.DrawEllipse(pen, X, Y - _width / 9, _width, _width / 4);


            if (!IsSelected) return;

            pen.Color = Color.Pink;
            g.DrawPolygon(pen, points);
            g.DrawEllipse(pen, X, Y - _width / 9, _width, _width / 4);

        }

        public override bool IsPointInside(Point point)
        {
            double A = Triangle.Area(p1.X, p1.Y, p2.X, p2.Y, p3.X, p3.Y);
            double A1 = Triangle.Area(point.X, point.Y, p2.X, p2.Y, p3.X, p3.Y);
            double A2 = Triangle.Area(p1.X, p1.Y, point.X, point.Y, p3.X, p3.Y);
            double A3 = Triangle.Area(p1.X, p1.Y, p2.X, p2.Y, point.X, point.Y);

            Point baseCenter = new Point((X + X +_width) / 2,
                                     (Y + Y + (_width / 4)) / 2);

            double xRadius = _width / 2.0;
            double yRadius = _width / 8.0;

            double d = ((double)Math.Pow((point.X - baseCenter.X), 2)
               / (double)Math.Pow(xRadius, 2))
              + ((double)Math.Pow((point.Y - baseCenter.Y), 2)
                 / (double)Math.Pow(yRadius, 2));


            return (A == A1 + A2 + A3) || d <= 1;
        }

        public override void EditShape()
        {
            Shape_Info_Input info = Shape_Info_Input.FromOneSide(true);
            if (!info.ForcedExit)
            {
                _width = info.ShapeWidth;
                _height = info.ShapeHeight;
            }
        }

        public override float GetArea()
        {
            int baseHeigth = _width / 4;
            
            double lSq = (Math.Pow(_height, 2) + Math.Pow((baseHeigth * _width), 2 )) / 4;
            double l = Math.Sqrt(lSq);

            double area = Math.PI * (baseHeigth + _width) * l
                       + (Math.PI * baseHeigth * _width);

            return (float)area;
        }

        public override Shape GetCopy() =>
            new Cone(X, Y, _width, _height, Color, BorderColor, undoStack, redoStack);


        public override void UndoStackPush(Shape shape) => undoStack.Push(shape);

        public override void RedoStackPush(Shape shape) => redoStack.Push(shape);

        public override Shape UndoStackPop() => undoStack.Pop();

        public override Shape RedoStackPop() => redoStack.Pop();

        public override void RedoClear() => redoStack.Clear();
    }
}
