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
    [Serializable]
    internal class Elipse : Shape
    {
        private readonly Stack<Shape> undoStack = new Stack<Shape>();
        private readonly Stack<Shape> redoStack = new Stack<Shape>();

        private int _width;
        private int _height;

        public override bool CanUndo => undoStack.Count > 0;
        public override bool CanRedo => redoStack.Count > 0;

        public Elipse(Shape_Info_Input info) : base(info)
        {
            _width = info.ShapeWidth;
            _height = info.ShapeHeight;
        }

        public Elipse(int x, int y, int width, int height,
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
        public override float GetArea() => (float)(Math.PI * _width * _height);

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
        public override void EditShape()
        {
            Shape_Info_Input info = Shape_Info_Input.FromOneSide(true);
            if (!info.ForcedExit)
            {
                _width = info.ShapeWidth;
                _height = info.ShapeHeight;
            }
        }
        public override bool IsPointInside(Point point)
        {
            Point center = new Point((X + X + _width) / 2,
                                     (Y + Y + _height) / 2);

            if (_width == _height)
            {
                int d = (point.X - center.X) * (point.X - center.X)
                      + (point.Y - center.Y) * (point.Y - center.Y);
                return d <= (_width / 2) * (_height / 2);
            }

            else
            { 
                double xRadius = _width / 2.0;
                double yRadius = _height / 2.0;

                double d = ((double)Math.Pow((point.X - center.X), 2)
                   / (double)Math.Pow(xRadius, 2))
                  + ((double)Math.Pow((point.Y - center.Y), 2)
                     / (double)Math.Pow(yRadius, 2));

                return d <= 1;
            }
        }
        public override Shape GetCopy() =>
            new Elipse(X, Y, _width, _height, Color, BorderColor, undoStack, redoStack);

        public override void UndoStackPush(Shape shape) => undoStack.Push(shape);

        public override void RedoStackPush(Shape shape) => redoStack.Push(shape);

        public override Shape UndoStackPop() => undoStack.Pop();

        public override Shape RedoStackPop() => redoStack.Pop();

        public override void RedoClear() => redoStack.Clear();

    }
}
