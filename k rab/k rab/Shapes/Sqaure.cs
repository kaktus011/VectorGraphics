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
    internal class Square : Shape
    {
        private int sideLength;

        public Square(Shape_Info_Input info) : base(info)
        {
            sideLength = info.ShapeSide;
        }

        public Square(int x, int y, int side) : base(x, y)
        {
            sideLength = side;
        }

        public override float GetArea()
        {
           return sideLength * sideLength;
        }

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
            sideLength = info.ShapeSide;
        }
        public override bool IsPointInside(Point point) =>
            base.IsPointInside(point) &&
            point.X <= X + sideLength &&
            point.Y <= Y + sideLength;

        public override Shape GetCopy() =>
            new Square(X, Y, sideLength);
    }
}
