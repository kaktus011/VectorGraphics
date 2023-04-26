using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaLibrary
{
    public class RectangleArea
    {
        public static double GetArea(int width, int height)
            => Math.Round(width * height  * 0.0264, 2);
    }
}
