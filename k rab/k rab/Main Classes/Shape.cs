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
        public int X { get; set; }
        public int Y { get; set; }
        public abstract float GetArea();
        public abstract void Draw(Graphics g, SolidBrush brush);

        public Shape(Shape_Info_Input info) : this(info._X, info._Y) { }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
