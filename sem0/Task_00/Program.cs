// 0. Демонстрация решения
// Напишите программу, которая на вход принимает число
// и выдает его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

int num = 4;
int square = num * num;

Console.WriteLine(square);

num = -3;
square = num * num;

Console.WriteLine(square);

num = -7;
square = num * num;

Console.WriteLine(square);

Console.Write("Введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());
square = num * num;
//Разные методы формирования строки
Console.WriteLine("Квадрат числа " + num + " = " + square);
Console.WriteLine($"Квадрат числа {num} = {square}");