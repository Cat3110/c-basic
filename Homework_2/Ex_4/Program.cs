using System;
using System.Threading.Tasks.Dataflow;

// Васильев Егор - Домашнее задание №2 - Задача 4

// Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
// С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменных для хранения введенного логина и пароля
            string login, passwd;
            // Счетчик попыток
            int count = 3;
            Console.WriteLine("Program \"Autorization\"");

            do
            {
                // Запрашиваем логин и пароль
                Console.WriteLine("Enter login");
                login = Console.ReadLine();
                Console.WriteLine("Enter password");
                passwd = Console.ReadLine();

                // Если данные верны, выходим из цикла и идем дальше
                if (CheckCredentials(login, passwd))
                {
                    Console.WriteLine("Your data is correct.");
                    break;
                }
                // Иначе уменьшаем количество попыток, просим ввести снова
                else
                {
                    count--;
                    Console.WriteLine("Your data is incorrect! Try again. You have {0} attempt(s)", count);
                }
            }
            while (count > 0);
        }
        

        // Метод проверки логина и пароля
        static bool CheckCredentials(string login, string passwd)
        {
            // На выходе истина если прошел авторизацию и ложь если не прошел
            return (login == "root") && (passwd == "GeekBrains") ? true : false;
        }
    }
}
