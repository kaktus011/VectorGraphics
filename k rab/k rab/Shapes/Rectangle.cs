﻿using k_rab.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    [Serializable]
    internal class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(Shape_Info_Input info) : base(info)
        {
            _width = info.ShapeWidth;
            _height = info.ShapeHeight;
        }

        public Rectangle(int x, int y, int width, int height,
                        Color color, Color borderColor) : base(x, y)
        {
            _width = width;
            _height = height;
            Color = color;
            BorderColor = borderColor;
        }

        public override float GetArea()
        {
           return _width * _height;
        }

        public override void Draw(Graphics g, SolidBrush brush, Pen pen)
        {
            brush.Color = Color;
            pen.Color = BorderColor;
            g.FillRectangle(brush, X, Y, _width, _height);
            g.DrawRectangle(pen, X, Y, _width, _height);
            if (!IsSelected) return;

            pen.Color = Color.Pink;
            g.DrawRectangle(pen, X, Y, _width, _height);
        }
        public override void EditShape()
        {
            Shape_Info_Input info = Shape_Info_Input.FromOneSide(true);
            _width = info.ShapeWidth;
            _height = info.ShapeHeight;
        }
        public override bool IsPointInside(Point point) =>
            base.IsPointInside(point) &&
            point.X <= X + _width &&
            point.Y <= Y + _height;

        public override Shape GetCopy() =>
            new Rectangle(X, Y, _width, _height, Color, BorderColor);
    }
}
