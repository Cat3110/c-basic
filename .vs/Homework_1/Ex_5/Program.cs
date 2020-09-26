using System;

// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) *Сделать задание, только вывод организовать в центре экрана.
// в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program \"Print\"");

            string name = "Egor";
            string surname = "Vasliyev";
            string town = "Novorossiysk";


            Print(name, surname, town);
        }

        static void Print(string a, string b, string c)
        {
            string result = $"Name: {a}, Surname: {b}, Town: {c}";

            int centerX = (Console.WindowWidth / 2) - (result.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;


            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine($"Name: {a}, Surname: {b}, Town: {c}");
        }
    }
}
