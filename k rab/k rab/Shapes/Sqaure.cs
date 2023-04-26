using k_rab.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kursovaLibrary;

namespace k_rab
{
    [Serializable]
    internal class Square : Shape
    {
        private readonly Stack<Shape> undoStack = new Stack<Shape>();
        private readonly Stack<Shape> redoStack = new Stack<Shape>();

        private int sideLength;

        public override bool CanUndo => undoStack.Count > 0;
        public override bool CanRedo => redoStack.Count > 0;

        public Square(Shape_Info_Input info) : base(info)
        {
            sideLength = info.ShapeSide;
        }

        public Square(int x, int y, int side, Color color, Color borderColor,
                      Stack<Shape> undo, Stack<Shape> redo) : base(x, y)
        {
            sideLength = side;
            Color = color;
            BorderColor = borderColor;
            undoStack = undo;
            redoStack = redo;
        }

        public override double GetArea() => SquareArea.GetArea(sideLength);

        public override void Draw(Graphics g, SolidBrush brush, Pen pen)
        {
            brush.Color = Color;
            pen.Color = BorderColor;
            g.FillRectangle(brush, X, Y, sideLength, sideLength);
            g.DrawRectangle(pen, X, Y, sideLength, sideLength);
            if (!IsSelected) return;

            pen.Color = Color.Pink; 
            g.DrawRectangle(pen, X, Y, sideLength, sideLength);
        }
        public override void EditShape()
        {
            Shape_Info_Input info = Shape_Info_Input.FromTwoSides(true);
            if (!info.ForcedExit)
                sideLength = info.ShapeSide;
        }
        public override bool IsPointInside(Point point) =>
            base.IsPointInside(point) &&
            point.X <= X + sideLength &&
            point.Y <= Y + sideLength;

        public override Shape GetCopy() =>
            new Square(X, Y, sideLength, Color, BorderColor, undoStack, redoStack);

        public override void UndoStackPush(Shape shape) => undoStack.Push(shape);

        public override void RedoStackPush(Shape shape) => redoStack.Push(shape);

        public override Shape UndoStackPop() => undoStack.Pop();

        public override Shape RedoStackPop() => redoStack.Pop();

        public override void RedoClear() => redoStack.Clear();
    }
}
