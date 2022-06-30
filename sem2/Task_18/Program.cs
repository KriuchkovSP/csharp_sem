// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y). 

Console.WriteLine ("Программа запрашивает номер координатной четверти и выводит диапазон возможных координат");
Console.Write ("Введите четверть: ");
int quarter = Convert.ToInt32 (Console.ReadLine());

string Coord (int q)
{
    switch (q)
    {
        case 1:
            return "Дипазон возможных координат X > 0 и Y > 0";
        case 2:
            return "Дипазон возможных координат X < 0 и Y > 0";
        case 3:
            return "Дипазон возможных координат X < 0 и Y < 0";
        case 4:
            return "Дипазон возможных координат X > 0 и Y < 0";
        default:
            return "Введена некорректная четверть";
    }
}

string result = Coord(quarter);

Console.WriteLine (result);
