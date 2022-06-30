// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Программа запрашивает координаты двух точек и выводит расстояние между ними");

Console.Write ("Введите координаты точки A (X Y Z) через пробел:");
int[] axyz = Console.ReadLine().Split().Select(int.Parse).ToArray();

Console.Write ("Введите координаты точки B (X Y Z) через пробел:");
int[] bxyz = Console.ReadLine().Split().Select(int.Parse).ToArray();

double Distance (int[] a, int[] b)
{
    int catx = 0;
    int caty = 0;
    int catz = 0;
    double result = 0.0;

    catx = Math.Max(a[0], b[0]) - Math.Min(a[0], b[0]);
    caty = Math.Max(a[1], b[1]) - Math.Min(a[1], b[1]);
    catz = Math.Max(a[2], b[2]) - Math.Min(a[2], b[2]);
    result = Math.Sqrt(catx * catx + caty * caty + catz * catz);
    return Math.Round(result,2);
}

double result = Distance(axyz, bxyz);
Console.WriteLine ($"Расстояние между точками A и B: {result}");