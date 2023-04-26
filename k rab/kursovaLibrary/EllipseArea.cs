using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaLibrary
{
    public class EllipseArea
    {

        public static double GetArea(int width, int height)
            => Math.Round(Math.PI* width * height* 0.0264, 2);

    }
}
