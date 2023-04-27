using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaLibrary
{
    public class Area
    {

        public static double Triangle(int sideLength) 
            => Math.Round(Math.Pow(sideLength, 2) *(Math.Sqrt(3) / 4) * 0.0264, 2);

        public static double Square(int sideLength)
            => Math.Round(sideLength * sideLength * 0.0264, 2);

        public static double Rectangle(int width, int height)
            => Math.Round(width * height  * 0.0264, 2);

        public static double Cone(int width, int height)
        {
            int baseHeigth = width / 4;

            double lSq = (Math.Pow(height, 2) + Math.Pow((baseHeigth * width), 2)) / 4;
            double l = Math.Sqrt(lSq);

            double area = Math.PI * (baseHeigth + width) * l
                       + (Math.PI * baseHeigth * width);

            return Math.Round(area  * 0.0264, 2);
        }

        public static double Ellipse(int width, int height)
            => Math.Round(Math.PI* width * height* 0.0264, 2);

    }
}
