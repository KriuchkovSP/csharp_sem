﻿// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает
// все целые числа в промежутке от -N до N.
//  4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Программа запрашивает целое число N выводит диапазон чисел от -N до N");
Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    int i = -n;
    Console.WriteLine("Полученный диапазон чисел от -N до N:");
    while (i < n)
    {
        Console.Write($"{i}, ");
        i++;
    }
    Console.WriteLine(n);
}
else
{
    int i = -n;
    Console.WriteLine("Полученный диапазон чисел от -N до N:");
    while (i > n)
    {
        Console.Write($"{i}, ");
        i--;
    }
    Console.WriteLine(n);
}