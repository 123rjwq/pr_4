using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите третье число: ");
        int number3 = int.Parse(Console.ReadLine());

        int maxOfTwo = GetMax(number1, number2);
        // Вызываем метод, передавая два первых числа
        int maxOfThree = GetMax(maxOfTwo, number3);
        // Вызываем метод, передавая результат и третье число

        Console.WriteLine("Максимальное число: " + maxOfThree);
    }

    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}


