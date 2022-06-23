// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет 
Console.WriteLine("Эта программа проверяет, является ли первое число квадратом второго.");
Console.Write("Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == (num2 * num2))
{
    Console.WriteLine($"Да, первое число является квадратом второго: {num2} * {num2} = {num1}");
}
else
{
    Console.WriteLine($"Нет, первое число не является квадратом второго: {num2} * {num2} != {num1}");
}
