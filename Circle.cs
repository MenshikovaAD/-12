using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    static class Circle
    {
        public static double GetLength(double radius)
        {
            return radius * 2 * Math.PI;

        }
        public static double GetSquare(double radius)
        {
            return Math.PI * radius;
        }
        public static double GetThree(double x, double y)
        {
            return (Math.Sqrt(x - 0) + Math.Sqrt(y - 0));
                         
        }
    }
}
