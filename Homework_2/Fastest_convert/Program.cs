using System;

// Программа сравнивает быстродействие двух способов конвертации: Convert.ToInt32 и Int.Parse

namespace Fastest_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start, finish;
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter integer number");
            string num = Console.ReadLine();

            start = DateTime.Now;
            Convert.ToInt32(num);
            finish = DateTime.Now;
            Console.WriteLine($"Convert.ToInt32 worked {finish - start}");

            start = DateTime.Now;
            int.Parse(num);
            finish = DateTime.Now;
            Console.WriteLine($"Int.Parse worked {finish - start}");

        }
    }
}
