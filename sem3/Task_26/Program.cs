// Задача 26:
// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Программа запрашивает целое число и определяет количество цифр в числе");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int DigCount(int number)
{
//    int digitCount = (int)Math.Log10(number) + 1; //Определяем количество разрядов
    int digitCount = 0;
    while (number != 0)
    {
        number /= 10;
        digitCount++;
    }
    return digitCount;
}
int result = DigCount(num); // Сохраняем результат вызванного метода

Console.WriteLine($"Введенное число {num} -> {result} значное"); // Вывод результата