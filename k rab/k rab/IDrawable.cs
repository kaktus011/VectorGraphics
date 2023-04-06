using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_rab
{
    internal interface IDrawable
    {
        void Draw(Graphics g, SolidBrush brush, Pen p);
        bool IsPointInside(Point point);
    }
}
