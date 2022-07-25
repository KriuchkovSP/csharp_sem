// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
    Console.WriteLine($"Полученная матрица:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j], 3}, ");
            else Console.Write ($"{array[i,j], 3}|");
        }
        Console.WriteLine();
    }
}

void PrintResult(int[,] array)
{
    for (int i = 1; i < array.GetLength(1); i++)
    {
        if (array[0, i] != array[0, i - 1])
        {
            Console.Write($"Число {array[0, i - 1]} встречается {array[1, i - 1]} ");
            if (array[1, i - 1] % 10 > 1 && array[1, i - 1] % 10 < 5) Console.WriteLine("раза");
            else Console.WriteLine("раз");
        }
    }
}

int[] MatrixToArray (int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[count] = array[i, j];
            count++;
        }
    }
    return result;
}

int[,] FreqNumArray(int[] array)
{
    int[,] result = new int[2,array.Length];
    int counter = 1;
    int num = 0;
    const int rowNum = 0;
    const int rowCount = 1;

    result[rowNum, num] = array[0];
    result[rowCount, num] = counter;

    for (int i = 1; i < array.Length; i++)
    {
        if (result[rowNum, num] == array[i]) counter++;
        else
        {
            result[rowCount, num] = counter;
            counter = 1;
            num++;
            result[rowNum, num] = array[i];
        }
        if (i == array.Length - 1 && result[rowNum, num] == array[i])
        {
            result[rowCount, num] = counter;
            result[rowNum, num] = array[i];
        }
    }
    return result;
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
int[] matrixToArray = MatrixToArray(genarr);
Array.Sort(matrixToArray);
int[,] resFreqInNumArray = FreqNumArray(matrixToArray);
PrintResult(resFreqInNumArray);
