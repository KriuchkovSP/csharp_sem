// Задача 53:
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void SwapRow (int[,] array)
{
    int tmpBuff = 0;
    int idx1 = 0;
    int idx2 = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tmpBuff = array[idx1, i];
        array[idx1, i] = array[idx2, i];
        array[idx2, i] = tmpBuff;
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
SwapRow(genarr);
PrintMatrix(genarr);
