// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Программа запрашивает 2 целых числа и сравнивает их");
Console.Write("Введите 1 целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Первое введенное число ({num1}) большее, второе введенное число ({num2}) меньшее, {num1} > {num2}");
}
else
{
    Console.WriteLine($"Первое введенное число ({num1}) меньшее, второе введенное число ({num2}) большее, {num1} < {num2}");
}