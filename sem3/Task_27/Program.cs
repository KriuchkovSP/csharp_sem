// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Программа запрашивает число и возвращает сумму цифр в числе");
Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

int DigSum(int num)
{
    int digsum = 0;
    while (num != 0)
    {
        digsum += num % 10;
        num /= 10;
    }

    return digsum;
}

int result = DigSum(number);
Console.WriteLine($"Сумма цифр в числе {number} -> {result}");