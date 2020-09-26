using System;
using System.Numerics;

// Васильев Егор - Домашнее задание №1 - Задача №3

// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2 - y1, 2).
// Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.


namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program \"Distance\"");

            // Вводим координаты первой точки
            Console.WriteLine("Enter first point coordinates");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            // Вводим координаты второй точки
            Console.WriteLine("Enter second point coordinates");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Считаем расстояние между точками
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Distance between points = {0:F2}", r);

            Console.WriteLine("Distance throw using method = {0:F2}", Distance(x1, y1, x2, y2));

        }

        static double Distance(double x1,double y1,double x2,double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

    }
}
