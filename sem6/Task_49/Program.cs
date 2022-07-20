// Задача 49:
// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти
// элементы на их квадраты. 


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите максимальное число диапазона: ");
int max =  Convert.ToInt32(Console.ReadLine());


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
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i,j],3}, ");
            else Console.Write($"{array[i,j],3}|");
        }
        Console.WriteLine();
    }
}

int[,] SqrParity(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] *= array[i, j];
        }
        Console.WriteLine();
    }
    return array;
}

int[,] genArray = CreateMatrixRndInt(m, n, min, max);
PrintMatrix(genArray);
int[,] resultArray = SqrParity(genArray);
PrintMatrix(resultArray);
