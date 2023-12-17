using System;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 10;
        // Инициализация первого числа
        int number2 = 20;
        // Инициализация второго числа

        Console.WriteLine("Исходные значения:");
        Console.WriteLine("number1 = " + number1);
        // Вывод исходного значения первого числа
        Console.WriteLine("number2 = " + number2);
        // Вывод исходного значения второго числа

        SwapValues(ref number1, ref number2);
        // Вызов метода SwapValues с передачей переменных по ссылке

        Console.WriteLine("Значения после замены:");
        Console.WriteLine("number1 = " + number1);
        // Вывод значения первого числа после замены
        Console.WriteLine("number2 = " + number2);
        // Вывод значения второго числа после замены
    }

    static void SwapValues(ref int a, ref int b)
    {
        int temp = a;
        // Создание временной переменной и сохранение значения первого числа в ней
        a = b;
        // Первому числу присваивается значение второго числа
        b = temp;
        // Второму числу присваивается значение из временной переменной
    }
}

