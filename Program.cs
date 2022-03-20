using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Метод находит длину окружности в зависимости от заданного пользователем радиуса круга

            Console.WriteLine("Введите радиус окружности ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double length = Circle.GetLength(radius);
            double square = Circle.GetSquare(radius);
            


            //Вывод результатов
            Console.WriteLine(" ");
            Console.WriteLine("При радиусе круга (R) = {0}", radius);
            Console.WriteLine("Длина окружности (L) = {0}", Math.Round(length,2));
            Console.WriteLine("Площадь круга (S) = {0}", Math.Round(square, 2));
            Console.WriteLine("Округление произведено до двух знаков после запятой");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Введите координаты точки Х:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки Y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double radiustwo = radius;
            double result = Circle.GetThree(x, y);

            if (result == Math.Sqrt(radiustwo))
            {
                Console.WriteLine(" Точка с координатами {0}, {1}", x, y + " принадлежит окружности");
            }
            if (result < Math.Sqrt(radiustwo))
            {
                Console.WriteLine(" Точка с координатами {0}, {1}", x, y + " принадлежит окружности");
            }
            else
            {
                Console.WriteLine(" Точка с координатами {0}, {1}", x, y + " не принадлежит окружности");
            }

            Console.WriteLine("");
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");
            Console.ReadKey();

        }
        
        
    }

    public class Point
    {
        double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static bool CheckPoint(Point center, double rad, Point point)
        {
            return (Math.Sqrt(Math.Pow(point.x - center.x, 2) + Math.Pow(point.y - center.y, 2)) <= rad);
        }
    }
}
