using System;

// Васильев Егор - Домашнее задание №2 - Задача 1

// Написать метод, возвращающий минимальное из трёх чисел.

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program \"Minimum\"");

            // Поочередно запрашиваем три числа для сравнения
            Console.WriteLine("Enter first number:");
            int one = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int three = int.Parse(Console.ReadLine());

            // Выводим результат
            Console.WriteLine("Minimum number is {0}", Min(one, two, three));

        }

        // Метод для поиска минимального числа
        static int Min(int one, int two, int three)
        {
            // Не самое изящное написание, зато короткое. 
            return (one < two) && (one < three) ? one : (two < one) && (two < three) ? two : three;
        }
    }
}
