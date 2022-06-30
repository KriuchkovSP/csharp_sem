// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Программа запрашивает число N и выводит таблицу кубов чисел");
Console.WriteLine ("Введите число N: ");
int n = Convert.ToInt32 (Console.ReadLine());

int i = 1;

Console.WriteLine ($"Таблица квадратов чисел от 1 до {n}:");
while (i <= n)
{
    Console.WriteLine ($"{i} -> {Math.Pow(i, 3), 5}");
    i++;
}
