// Задача 54:
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки
// двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

int[,] SortMatrixToCol(int[,] array)
{
    int tempBuffer = 0;
    int j = array.GetLength(1) - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        while (j >= 0)
        {
            for (int k = 0; k < j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    tempBuffer = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = tempBuffer;
                }
            }
            j--;
        }
        j = array.GetLength(1) - 1;
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
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j], 5}, ");
            else Console.Write ($"{array[i,j], 5}|");
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

int[,] genarr = CreateMatrixRndInt(rows, cols, minD, maxD);
PrintMatrix(genarr);
int[,] resarr = SortMatrixToCol(genarr);
PrintMatrix(resarr);
