// Задача 55:
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j], 5}, ");
            else Console.Write ($"{array[i,j], 5}|");
        }
        Console.WriteLine();
    }
}

void SwapRowCol (int[,] array)
{
    int tmpBuff = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            tmpBuff = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = tmpBuff;
        }
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

if (rows == cols)
{
    int[,] genarr = CreateMatrixRndInt(rows, cols, minD, maxD);
    PrintMatrix(genarr);
    SwapRowCol(genarr);
    PrintMatrix(genarr);
}
else
{
    Console.Write ("Матрица не квадратная, поменять строки со столбцами не возможно");
}

