using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите r:");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты x0 и y0 центра окружности");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты x и y точки");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Длина окружности: {Circle.Length(r):F2} \n" +
                $"Площадь круга: {Circle.Square(r):F2} \n" +
                $"{Circle.isLiesOn(x, y, r, x0, y0)}");
            Console.ReadKey();
        }
    }
}
