// Задача 52.
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int col, int begin, int end)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(begin, end + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    Console.WriteLine($"Сгенерированная матрица:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j],2}, ");
            else Console.Write ($"{array[i,j],2}|");
        }
        Console.WriteLine();
    }
}

double[] SearchAverCol (int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[j] += (double)array[i, j];
        }
        result[j] /= array.GetLength(0);
    }
    return result;
}

void PrintAverCol (double[] array)
{
    Console.Write ("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine($"{array[array.Length - 1]}.");
}

int[,] arrayResult = CreateMatrixRndInt(4, 4, 0, 99);
PrintMatrix(arrayResult);
double[] resAverCol = SearchAverCol(arrayResult);
PrintAverCol(resAverCol);
