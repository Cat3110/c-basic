using System;
using System.Xml;

// Васильев Егор - Домашнее задание №3 - Задача 1

// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.


struct ComplexStruct
{
    public double im;
    public double re;
    //  в C# в структурах могут храниться также действия над данными
    public ComplexStruct Plus(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    //  Пример произведения двух комплексных чисел
    public ComplexStruct Multi(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    // Вычитаение комплексных чисел
    public ComplexStruct Delta(ComplexStruct x)
    {
        ComplexStruct y;
        y.re = re - x.re;
        y.im = im - x.im;
        return y;
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}
class ComplexClass
{
    // Поля приватные.
    private double im;
    // По умолчанию элементы приватные, поэтому private можно не писать.
    double re;

    // Конструктор без параметров.
    public ComplexClass()
    {
        im = 0;
        re = 0;
    }

    // Конструктор, в котором задаем поля.    
    // Специально создадим параметр re, совпадающий с именем поля в классе.
    public ComplexClass(double _im, double re)
    {
        // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
        im = _im;
        // Чтобы показать, что к полю нашего класса присваивается параметр,
        // используется ключевое слово this
        // Поле параметр
        this.re = re;
    }
    public ComplexClass Plus(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }
    public ComplexClass Multi(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = re * x2.im + im * x2.re;
        x3.re = re * x2.re - im * x2.im;
        return x3;
    }
    public ComplexClass Delta(ComplexClass x2)
    {
        ComplexClass x3 = new ComplexClass();
        x3.im = x2.im - im;
        x3.re = x2.re - re;
        return x3;
    }
    // Свойства - это механизм доступа к данным класса.
    public double Im
    {
        get { return im; }
        set
        {
            // Для примера ограничимся только положительными числами.
            if (value >= 0) im = value;
        }
    }
    // Специальный метод, который возвращает строковое представление данных.
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Switch для демонстрации 
        Console.WriteLine("Enter S if you want to check structure.");
        Console.WriteLine("Enter C if you want to check class.");

        string selector = Console.ReadLine();

        switch (selector)
        {
            case "S":
                CheckStructure();
                break;
            case "C":
                CheckClass();
                break;
            default:
                break;
        }
    }
    static public void CheckStructure()
    {
        // Первое число
        ComplexStruct complex1;
        complex1.re = 3;
        complex1.im = 3;

        // Второе число
        ComplexStruct complex2;
        complex2.re = -1;
        complex2.im = 1;

        // Сумма комплексных чисел
        ComplexStruct result = complex1.Plus(complex2);
        Console.WriteLine($"Sum: {result.ToString()}");

        // Произведение комплексных чисел
        result = complex1.Multi(complex2);
        Console.WriteLine($"Multi: { result.ToString()}");

        // Разница комплексных чисел
        result = complex1.Delta(complex2);
        Console.WriteLine($"Delta: { result.ToString()}");
    }

    static public void CheckClass()
    {
        // Описали ссылку на объект.
        ComplexClass complex1;
        // Создали объект и сохранили ссылку на него в complex1.
        complex1 = new ComplexClass(1, 1);
        // Описали объект и создали его.
        ComplexClass complex2 = new ComplexClass(2, 2);
        // С помощью свойства Im изменили внутреннее (приватное) поле im.
        complex2.Im = 3;
        // Создали ссылку на объект.
        ComplexClass result;
        // Так как в методе Plus создается новый объект,
        // в result сохраняем ссылку на вновь созданный объект.
        result = complex1.Plus(complex2);
        Console.WriteLine($"Sum: {result.ToString()}");

        // Выводим произведение
        result = complex1.Multi(complex2);
        Console.WriteLine($"Multi: { result.ToString()}");

        // Выводим разницу
        result = complex1.Delta(complex2);
        Console.WriteLine($"Delta: { result.ToString()}");
    }
}
