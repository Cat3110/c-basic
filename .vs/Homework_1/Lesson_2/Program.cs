using System;

// Васильев Егор - Домашнее задание №1 - Задача №2

// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program \"BMI\"");
            // Вводим вес
            Console.WriteLine("Enter your weigh");
            int weigh = Convert.ToInt32(Console.ReadLine());

            // Вводим рост в метрах
            Console.WriteLine("Enter your height in meters");
            double height = Convert.ToDouble(Console.ReadLine());

            // Считаем Body Mass Index
            double BMI = weigh / (height * height);

            // Выводим результат в консоль
            Console.WriteLine("Your BMI: {0:F2}", BMI);
        }
    }
}
