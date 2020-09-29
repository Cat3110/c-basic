using System;
using System.Threading;

// Васильев Егор - Домашнее задание №2 - Задача 5

// *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
// «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

namespace Ex_6
{
    class Program
    { 
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int count = 0;

            for (int i = 1; i < 10000; i++)
            {
                count += CheckGood(i);
            }
            
            Console.WriteLine($"Number of \"Good\" numbers: {count}");
            Console.WriteLine($"Time of execute: {DateTime.Now - start}");
        }

        static int CheckGood(int n)
        {
            return (n % DigitSum(n) == 0) ? 1 : 0;
        }

        static int DigitSum(int n)
        {
            if (n == 0)
                return 0;
            else
                return DigitSum(n / 10) + n % 10;
        }

    }
}
