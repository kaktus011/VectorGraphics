using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaLibrary
{
    public class ConeArea
    {
        public static double GetArea(int width, int height)
        {
            int baseHeigth = width / 4;

            double lSq = (Math.Pow(height, 2) + Math.Pow((baseHeigth * width), 2)) / 4;
            double l = Math.Sqrt(lSq);

            double area = Math.PI * (baseHeigth + width) * l
                       + (Math.PI * baseHeigth * width);

            return Math.Round(area  * 0.0264, 2);
        }
    }
}
