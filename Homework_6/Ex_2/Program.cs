using System;
using System.Collections.Generic;
using System.IO;

// Васильев Егор - Домашнаяя работа №6 - Задание 2

// Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
// а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
// Использовать массив (или список) делегатов, в котором хранятся различные функции.
// б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out). 


namespace Ex_2
{
    class Program
    {
        public delegate double Function(double x);

        public static void SaveFunc(Function function, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(function(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);

            double[] result = new double[fs.Length / sizeof(double)];

            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                result[i] = d;
            }
            bw.Close();
            fs.Close();

            return result;
        }

        static void Main(string[] args)
        {
            // Создаем список делегатов и обновляем его.
            List<Function> function = new List<Function>();
            function.Add((x) => { return (x * x); });
            function.Add((x) => { return Math.Sin(x); });
            function.Add((x) => { return Math.Log10(x); });

            Console.WriteLine("Enter left border of interval");
            double a = double.Parse(Console.ReadLine());            
            Console.WriteLine("Enter right border of interval");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose function to process:");
            Console.WriteLine("1 for x^2");
            Console.WriteLine("2 for sin(x)");
            Console.WriteLine("3 for Log(x)");

            switch (Console.ReadLine())
            {
                case "1":
                    SaveFunc(function[0], "data.bin", a, b, 1);
                    break;
                case "2":
                    SaveFunc(function[1], "data.bin", a, b, 1);
                    break;
                case "3":
                    SaveFunc(function[2], "data.bin", a, b, 1);
                    break;
                default:
                    Console.WriteLine("Wrong option! Default option was choosen: x^2");
                    SaveFunc(function[0], "data.bin", a, b, 1);
                    break;
            }

            double min;
            double[] result;
            result = Load("data.bin", out min);
            Console.WriteLine($"Min: {min}");

            Console.WriteLine("Data in file:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();
        }
    }

}
