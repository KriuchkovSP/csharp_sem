// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

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

int[] SummRowMatrix(int[,] array)
{
    int sumRow = 0;
    int[] resSumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        resSumRow[i] = sumRow;
        sumRow = 0;
    }
    return resSumRow;
}

int SearchPositionMinElement(int[] array)
{
    int minPosEl = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minPosEl]) minPosEl = i;
    }
    return minPosEl;
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

void PrintResultSearch(int position)
{
    Console.WriteLine($"Строка с наименьшей суммой элементов: {position + 1}"); //Для отсчета с 1
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
int[] sumRowMatrix = SummRowMatrix(genarr);
int posMinSumRowMatrix = SearchPositionMinElement(sumRowMatrix);
PrintResultSearch(posMinSumRowMatrix);

