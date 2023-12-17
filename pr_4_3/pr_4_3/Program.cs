﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Задаем целочисленный массив
        int sum = 0;
        // Переменная для хранения суммы элементов
        int product = 1;
        // Переменная для хранения произведения элементов

        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[" + i + "] = " + array[i]);
            // Выводим элементы массива
            if (i % 2 == 0) 
                // Проверяем, является ли индекс четным
            {
                sum += array[i];
                // Добавляем элемент к сумме на четных позициях
                product *= array[i];
                // Умножаем элемент на произведение на четных позициях
            }
        }

        Console.WriteLine("Сумма элементов на четных местах: " + sum);
        // Выводим сумму элементов на четных позициях
        Console.WriteLine("Произведение элементов на четных местах: " + product);
        // Выводим произведение элементов на четных позициях
    }
}
