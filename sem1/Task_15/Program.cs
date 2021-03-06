// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Программа запрашивает целое число и выводит соответствующий день недели");
Console.Write("Введите целое число от 1 до 7: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

string DayWeek (int day)
{
    if (day < 1 || day > 7) return $"Введен некорректный день недели {day}";
    if (day == 6 || day == 7) return $"Введеный день {day} выходной";
    return $"Введеный день {day} не является выходным";
}

Console.WriteLine(DayWeek(dayWeek));