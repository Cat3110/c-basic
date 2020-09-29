using System;

// Васильев Егор - Домашнее задание №2 - Задача 5


// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program \"BMI\"");

            // Запрашиваем массу и рост человека
            Console.WriteLine("Enter your weigh");
            int weigh = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in m");
            float height = float.Parse(Console.ReadLine());

            // Вычисляем индекс массы
            float BMI = weigh / (height * height);

            // Выводим индекс
            Console.WriteLine("Your BMI: {0:F1}", BMI);

            if (BMI < 19)
            {
                Console.WriteLine($"You need gain {DeltaMass(weigh, height)} kg");
            } 
            else if (BMI > 30)
            {
                Console.WriteLine($"You need loose {DeltaMass(weigh, height)} kg");
            }
            else
            {
                Console.WriteLine("You have normal weigh");
            }

        }

        // Функция для расчета дельты массы
        static int DeltaMass(int weigh, float height)
        {
            // Для расчетов берем среднее нормальное значение
            int normalBMI = 27;

            return Math.Abs(Convert.ToInt32(normalBMI * (height * height) - weigh));

        }
    }
}
