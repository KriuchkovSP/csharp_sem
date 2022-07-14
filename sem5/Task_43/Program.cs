// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями
// y = k1 * x + b1,
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("Программа поиска точки пересечения двух прямых");
Console.WriteLine ("Формула прямой y = k * x + b");

Console.Write("Введите значение коэффициента наклона первой прямой k: ");
int inK1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение коэффициента смещения первой прямой b: ");
int inB1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение коэффициента наклона второй прямой k: ");
int inK2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение коэффициента смещения первой прямой b: ");
int inB2 = Convert.ToInt32(Console.ReadLine());

double[] IntersectPnt(int k1, int b1, int k2, int b2)
{
    double x = Math.Round((double)(b2 - b1) / (k1 - k2),2); // т.к. в точке пересечения х и y в обоих уравнениях прямых совпадают,
                                      // приравняем уравнения и выразим х для вычисления
    double y = Math.Round(k1 * x + b1, 2); // подставим вычисленный х в уравнение прямой (любой, т.к. y1 = y2 в т. пересечения)

    return new[] {x,y};
}

void PrintArr(double[] array)
{
    Console.Write ("Координаты точки пересечения прямых:");
    for (int i = 0; i < array.Length;i++)
    {
        if (i == 0) Console.Write("(");
        if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
        else Console.WriteLine ($"{array[i]})");
    }
}

double[] resPoint = IntersectPnt(inK1, inB1, inK2, inB2);
PrintArr (resPoint);