using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaLibrary
{
    public class TriangleArea
    {

        public static double GetArea(int sideLength)
            => Math.Round(Math.Pow(sideLength, 2) *(Math.Sqrt(3) / 4) * 0.0264, 2);

    }
}
