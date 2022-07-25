// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] GetPosMinEl(int[,] array)
{
    int minPosElementRow = 0;
    int minPosElementCol = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minPosElementRow, minPosElementCol])
            {
                minPosElementRow = i;
                minPosElementCol = j;
            }
        }
        
    }
    return new[] {minPosElementRow, minPosElementCol};
}

int[,] DeleteRowCowMinElementMatrix(int[,] array, int[] position)
{
    int rowNewMatrix = array.GetLength(0) - 1;
    int colNewMatrix = array.GetLength(1) - 1;
    int[,] resMatrix = new int[rowNewMatrix, colNewMatrix];
    bool flagAddRow = false;
    bool flagAddCol = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == position[0] && i != rowNewMatrix - 1)
        {
            flagAddRow = true;
            i++;
        }
        else if (i == position[0] && i == rowNewMatrix - 1) break;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == position[1] && j != colNewMatrix - 1)
            {
                flagAddCol = true;
                j++;
            }
            else if (j == position[1] && j == colNewMatrix - 1) break;
            if (flagAddRow && flagAddCol) resMatrix[i - 1, j - 1] = array[i, j];
            else if (flagAddRow) resMatrix[i - 1, j] = array[i, j];
            else if (flagAddCol) resMatrix[i, j - 1] = array[i, j];
            else resMatrix[i, j] = array[i, j];
        }
        flagAddCol = false;
    }
    return resMatrix;
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

void PrintMinEl(int[,] array, int[] position)
{
    // Ориентируемся на пользователя, начинающего отсчет с 1
    Console.WriteLine($"Наименьший элемент матрицы: {array[position[0], position[1]]}:  {position[0] + 1} - строка, {position[1] + 1} - столбец");
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
int[] posMinEl = GetPosMinEl(genarr);
int[,] resultMatrix = DeleteRowCowMinElementMatrix(genarr, posMinEl);
PrintMinEl(genarr, posMinEl);
PrintMatrix(resultMatrix);
