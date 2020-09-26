using System;

// *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

namespace EX_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }

    class Utilities
    {
        static void Print(string str)
        {
            Console.WriteLine(str);
        }

        static void Pause()
        {
            Console.ReadKey();
        }
    }
}
