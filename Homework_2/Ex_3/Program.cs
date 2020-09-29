using System;

// Васильев Егор - Домашнее задание №2 - Задача 3

// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел


namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program \"Sum\"");

            // Переменная для подсчета суммы
            int sum = 0;
            // Переменная для хранения ввода
            int num = 1;

            // Пока введенное число не равно нулю
            while (num != 0)
            {
                // Запрашиваем число
                Console.WriteLine("Enter a number. Zero to stop");
                num = int.Parse(Console.ReadLine());

                // Проверяем, что число положительное и нечетное и прибавляем к результаты
                if ((num > 0) && ((num % 2) == 1)) 
                    sum += num;
            }

            // Выводим результат
            Console.WriteLine($"Result: {sum}");


        }
    }
}
