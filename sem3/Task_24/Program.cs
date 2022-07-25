// Задача 24: Напишите програму, которая
// принимает на вход число (А) и выдает сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
//int a = int.Parse(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());

int Sum (int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}  

int res = Sum(a);
Console.WriteLine($"Сумма чисел от 1 до {a} -> {res}");
// Задача 24: Напишите програму, которая
// принимает на вход число (А) и выдает сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
//int a = int.Parse(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());

int Sum (int num)
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}  

int res = Sum(a);
Console.WriteLine($"Сумма чисел от 1 до {a} -> {res}");
