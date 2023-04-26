using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaLibrary
{
    public class SquareArea
    {
        public static double GetArea(int sideLength)
            => Math.Round(sideLength * sideLength * 0.0264, 2);

    }
}
