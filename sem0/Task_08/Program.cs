// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Программа запрашивает целое положительное число N и выводит все четные числа от 1 до N");
Console.Write("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 1)
{
    Console.WriteLine("Полученные четные числа от 1 до N: ");
    int i = 2;
    while (i < n - 1)
    {
        Console.Write($"{i}, ");
        i += 2;
    }
    if ((n % 2) == 0) Console.WriteLine(i);
    else Console.WriteLine(i);
}
else Console.WriteLine("В введенном диапазоне нет четных чисел");