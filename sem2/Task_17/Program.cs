// 17. Напишите программу, которая принимает на вход
// координаты точки (Х и Y), причем X != 0 и Y != 0 и выдает
// номер четверти плоскости, в которой находится эта точка.

Console.WriteLine ("Введите координаты точки (X и Y)");
Console.Write ("X: ");
int x = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Y: ");
int y = Convert.ToInt32 (Console.ReadLine());




string Quarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены некорректные координаты";
}
string result = Quarter(x, y);

Console.WriteLine (result);
