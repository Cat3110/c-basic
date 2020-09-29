using System;

// Васильев Егор - Домашнее задание №2 - Задача 7

// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.


namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program \"Recursion\"");

            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());            
            
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: ");

            Numbers(a, b);

            Console.WriteLine($"Sum: {Sum(a,b)}");
        }

        static int Numbers(int a, int b)
        {
            Console.WriteLine(a);
            if (a == b)
                return 0;
            else
                return Numbers(++a, b);
        }

        static int Sum(int a, int b)
        {
            if (a == b)
                return b;
            else
                return a += Sum(a+1, b);
        }
    }
}
