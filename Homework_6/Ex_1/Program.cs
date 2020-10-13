using System;

// Васильев Егор - Домашнаяя работа №6 - Задание 1

// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

namespace Ex_1
{
    public delegate double Function(double x, double a);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Table(F1, -10, 10, 1);
            Table(F2, -10, 10, 1);

        }

        // Метод для вывода таблицы функции
        public static void Table(Function function, double xMin, double xMax, double a)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (xMin < xMax)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", xMin, function(xMin, a));
                xMin += 1;
            }
            Console.WriteLine("---------------------");
        }

        // Первая функция
        public static double F1(double x, double a)
        {
            return a * x * x;
        }       

        // Вторая функция
        public static double F2(double x, double a)
        {
            return a * Math.Sin(x);
        }
    }
}
