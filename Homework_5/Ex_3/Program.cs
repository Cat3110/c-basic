using System;

// Васильев Егор - Домашная работа №5 - Задание 3.

// *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
// Например:
// badc являются перестановкой abcd.

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first and second strings");
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine(Permutation(a, b));
        }

        static bool Permutation(string a, string b)
        {
            // Сравниваем длины строк
            if (a.Length != b.Length)
                return false;

            // Считаем количество символов в первой строке
            int[] letters = new int[256];
            char[] sArray = a.ToCharArray();
            foreach (char c in sArray)
            {
                letters[c]++;
            }

            // Проверяем на перестановку
            for (int i = 0; i < b.Length; i++)
            {
                int c = (int)b[i];
                if (--letters[c] < 0)
                    return false;
            }

            return true;
        }
    }
}
