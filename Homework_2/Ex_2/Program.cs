using System;

// Васильев Егор - Домашнее задание №2 - Задача 2

// Написать метод подсчета количества цифр числа.

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start;
            Console.WriteLine("Program \"Digits\"");

            // Вводим числа
            Console.WriteLine("Enter number for digit counts");
            int num = int.Parse(Console.ReadLine());

            // Считаем время выполнения и выводим результат
            start = DateTime.Now;
            Console.WriteLine($"Counting throw Loop: Number {num} has {DigitsLoop(num)} digits. Metod worked {DateTime.Now - start} ");

            // Считаем время выполнения и выводим результат
            start = DateTime.Now;
            Console.WriteLine($"Counting throw String: Number {num} has {DigitsString(num)} digits. Metod worked {DateTime.Now - start} ");

        }

        // Считаем количество цифр через цикл и деление
        static int DigitsLoop(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }

        // Считаем количество цифр через преобразование в строку и определение длины строки
        static int DigitsString(int num)
        {
            return num.ToString().Length;
        }
    }
}
