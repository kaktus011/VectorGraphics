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
        public abstract float GetArea();
        public abstract void Draw(Graphics g, SolidBrush brush);
    }
}
