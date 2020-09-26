using System;

// Васильев Егор - Домашнее задание №1 - Задача №1

// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.

// Вопросы:
// 1. Почему русские символы в консоли не выводятся, вместо них квадраты. Проблемы с кодировкой? Как исправить? Windows10 англоязычная
// 2. Почему не работает int.TryParse(Console.ReadLine())?

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Program \"Questionary\"");
            // Ввод данных о пользователе
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your weigh");
            int weigh = Convert.ToInt32(Console.ReadLine());

            // Выводим данные используя склеивание
            Console.WriteLine("Name: " + name + " Surname: " + surname + " Age: " + age + " Height: " + height + " Weight: " + weigh);

            // Выводим данные, используя форматированный вывод
            Console.WriteLine("Name: {0} Surname: {1} Age: {2} Height: {3} Weight: {4}", name, surname, age, height, weigh);

            // Выводим данные, используя вывод со знаком $
            Console.WriteLine($"Name: {name} Surname: {surname} Age: {age} Height: {height} Weight: {weigh}");
        }
    }
}
