// Задача 58:
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[] InputDataForMatrix()
{
    Console.Write ("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine ());
    Console.Write ("Введите количество столбцов массива: ");
    int cols = Convert.ToInt32(Console.ReadLine ());
    Console.Write ("Введите минимальное число диапазона: ");
    int minD = Convert.ToInt32(Console.ReadLine ());
    Console.Write ("Введите максимальное число диапазона: ");
    int maxD =  Convert.ToInt32(Console.ReadLine ());
    return new[] {rows, cols, minD, maxD};
}

int[,] MatrixMul(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] result = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                result[i,j] += arrayOne[i,k] * arrayTwo[k,j];
            }
        }
    }
    return result;
}

bool CheckMatrixForMul(int[,] arrayOne, int[,] arrayTwo)
{
    if (arrayOne.GetLength(1) == arrayTwo.GetLength(0)) return true;
    else return false;
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

Console.WriteLine ("Введите данные для первой матрицы: ");
int[] dataForMatrixOne = InputDataForMatrix();
Console.WriteLine ("Введите данные для второй матрицы: ");
int[] dataForMatrixTwo = InputDataForMatrix();

int[,] matrixOne = CreateMatrixRndInt(dataForMatrixOne[0], dataForMatrixOne[1], dataForMatrixOne[2], dataForMatrixOne[3]);
PrintMatrix(matrixOne);
int[,] matrixTwo = CreateMatrixRndInt(dataForMatrixTwo[0], dataForMatrixTwo[1], dataForMatrixTwo[2], dataForMatrixTwo[3]);
PrintMatrix(matrixTwo);
bool resCheckMatrix = CheckMatrixForMul(matrixOne, matrixTwo);
int[,] resMulMatrix = new int [matrixOne.GetLength(0), matrixTwo.GetLength(1)];
if (resCheckMatrix)
{
    resMulMatrix = MatrixMul(matrixOne, matrixTwo);
    PrintMatrix(resMulMatrix);
}
else Console.WriteLine("Умножение матриц невозможно");
