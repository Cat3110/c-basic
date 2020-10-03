using System;

// Васильев Егор - Домашнее задание №3 - Задача 2

// а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
// Требуется подсчитать сумму всех нечётных положительных чисел. 
// Сами числа и сумму вывести на экран, используя tryParse.

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Sum: {0}", Sum());

        }

        static int Sum()
        {
            int n;
            Console.WriteLine("Enter a number, 0 to stop");
            bool success = int.TryParse(Console.ReadLine(), out n);

            if ((!success) || (n == 0))
                return 0;

            if ((n > 0) && (n % 2) == 1)
                return n + Sum();
            else
                return Sum();

        }
    }
}
