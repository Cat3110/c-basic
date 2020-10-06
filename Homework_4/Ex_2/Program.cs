using System;
using System.IO;

// Васильев Егор - Домашнее задание №4 - Упражнение №2

// Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
// в)**Добавьте обработку ситуации отсутствия файла на диске.


namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];

            a = StaticClass.ReadArrayFromFile();

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a);
            }
        }

        static class StaticClass
        {
            // Статический метод, решающий задачу 1
            static public int SpecialCount(int[] a)
            {
                // Находим и выводим количество пар элементов массива, в которых только одно число делится на 3.
                int count = 0;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (((a[i] % 3 == 0) && (a[i + 1] % 3 != 0)) || ((a[i] % 3 != 0) && (a[i + 1] % 3 == 0))) count++;
                }

                return count;
            }

            static public int[] ReadArrayFromFile()
            {
                int[] a = new int[1];
                int counter = 0;
                StreamReader sr = new StreamReader("..\\..\\..\\data.txt");
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    Console.WriteLine("Read line: " + s);
                    a[counter] = int.Parse(s);
                    Array.Resize(ref a, a.Length + 1);
                    counter++;
                }
                sr.Close();
                return a;
            }

        }
    }
}
