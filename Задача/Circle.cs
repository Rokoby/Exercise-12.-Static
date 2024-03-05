using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    static class Circle
    {
        public static double Length (double r)
        {
            return 2*Math.PI*r;
        }
        public static double Square (double r)
        {
            return Math.PI*r*r;
        }
        public static string isLiesOn (double x ,double y, double r, double x0, double y0)
        {
            if (Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0)) == r)
                return "Точка принадлежит кругу";
            else 
                return "Точка не принадлежит кругу";
        }
    }
}
