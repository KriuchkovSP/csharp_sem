// Задача 47.
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5      7    -2    -0,2
//   1   -3,3     8    -9,9
//   8    7,8  -7,1       9


double[,] CreateMatrixRndDoub (int row, int col, int begin, int end)
{
    double[,] array = new double[row, col];
    double tempgen = 0.0;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempgen = rnd.NextDouble() * (end - begin) + begin;
            array[i, j] = Math.Round(tempgen, 2);
        }  
    }
    return array;
}


void PrintMatrix(double[,] array)
{
    Console.WriteLine ($"Сгенерированный двумерный массив из {array.GetLength(0)} x {array.GetLength(1)} элементов:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j],7} ");
            else Console.Write ($"{array[i,j],7}|");
        }
        Console.WriteLine();
    }
}


Console.Write ("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите минимальное число диапазона: ");
int minD = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите максимальное число диапазона: ");
int maxD =  Convert.ToInt32(Console.ReadLine ());

double[,] genarr = CreateMatrixRndDoub(rows, cols, minD, maxD);
PrintMatrix(genarr);
