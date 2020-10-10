using System;
using System.Text.RegularExpressions;

// Васильев Егор - Домашная работа №5 - Задание 1.

// Создать программу, которая будет проверять корректность ввода логина. 
// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) **с использованием регулярных выражений.

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            // Цикл для ожидания ввода корректного логина
            do
            {
                Console.WriteLine("Enter login");
                login = Console.ReadLine();
            } while (!CheckCorrectWithRegular(login));
            Console.WriteLine($"Login: {login} is correct");
        }

        // Проверка корректности без регулярных выражений
        static bool CheckCorrect(string login)
        {
            // Проверяем что не короче 2 символов
            if (login.Length < 2) 
                return false;
            // Проверяем что не длиннее 10 символов
            if (login.Length > 10) 
                return false;
            // Проверяем что цифра не первая
            if (Char.IsDigit(login[0]))
                return false;
            // Проверяем, что только буквы и цифры
            for (int i = 0; i < login.Length; i++)
            {
                if(!Char.IsLetterOrDigit(login[i]))
                    return false;
            }
            return true;
        }
        // Проверка корректности с регулярными выражениями
        static bool CheckCorrectWithRegular(string login)
        {
            Regex myReg = new Regex(@"^[a-zA-Z]{1}\w{1,9}$");
            if (myReg.IsMatch(login))
                return true;
            return false;
        }
    }
}
