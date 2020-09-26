using System;

// Васильев Егор - Домашнее задание №1 - Задача №3

// Написать программу обмена значениями двух переменных:
// а) с использованием третьей переменной;
// б) *без использования третьей переменной.

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program \"Exchange\"");

            Console.WriteLine("Enter first variable");
            string a = Console.ReadLine();            

            Console.WriteLine("Enter second variable");
            string b = Console.ReadLine();

            // С использованием третьей переменной
            string temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a = {a}, b = {b}");

            // Без использования третьей переменной
            Console.WriteLine("Enter first variable");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second variable");
            int d = Convert.ToInt32(Console.ReadLine());

            c = c ^ d;
            d = c ^ d;
            c = c ^ d;

            Console.WriteLine($"c = {c}, d = {d}");






        }
    }
}
