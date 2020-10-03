using System;

// Васильев Егор - Домашнее задание №3 - Задача 3

// *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
// Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
// * Добавить свойства типа int для доступа к числителю и знаменателю;
// *Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
// **Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
// ***Добавить упрощение дробей.

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // First rational number
            Rational n1 = new Rational();
            n1.Numerator = 2;
            n1.Denominator = 4;

            // Second rational number
            Rational n2 = new Rational();
            n2.Numerator = 3;
            n2.Denominator = 4;

            // Results
            Console.WriteLine($"Sum: {n1.Sum(n2).ToString()}");
            Console.WriteLine($"Delta: {n1.Delta(n2).ToString()}");
            Console.WriteLine($"Multi: {n1.Multi(n2).ToString()}");
            Console.WriteLine($"Div: {n1.Div(n2).ToString()}");

            Console.WriteLine($"N1 Dec: {n1.Decimal}");
            Console.WriteLine($"N2 Dec: {n2.Decimal}");

            Normalize(n1);

        }
        // Метод для нормализации
        static void Normalize(Rational n)
        {
            int nod = NOD(n.Numerator, n.Denominator);
            int num = n.Numerator / nod;
            int den = n.Denominator / nod;

            // Возвращаем результат
            Console.WriteLine($"Normalize for {n.ToString()} is {num}/{den}");
        }
        // Метод для поиска НОД для функции нормализации
        static int NOD(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
    }

    class Rational
    {
        // Числитель, знаменатель
        private int numerator, denominator;

        // Конструктор без параметров
        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }
        // Конструктор с параметрами
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public Rational Sum(Rational r2)
        {
            Rational result = new Rational();
            result.numerator = numerator * r2.denominator + r2.numerator * denominator;
            result.denominator = denominator * r2.denominator;
            return result;
        }
        public Rational Delta(Rational r2)
        {
            Rational result = new Rational();
            result.numerator = numerator * r2.denominator - r2.numerator * denominator;
            result.denominator = denominator * r2.denominator;
            return result;
        }
        public Rational Multi(Rational r2)
        {
            Rational result = new Rational();
            result.numerator = numerator * r2.numerator;
            result.denominator = denominator * r2.denominator;
            return result;
        }
        public Rational Div(Rational r2)
        {
            Rational result = new Rational();
            result.numerator = numerator * r2.denominator;
            result.denominator = denominator * r2.numerator;
            return result;
        }
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Denominator can't be zero");
                else
                    denominator = value;
            }
        }
        public double Decimal
        {
            get
            {
                return Convert.ToDouble(numerator) / denominator;
            }
        }
        public string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}
