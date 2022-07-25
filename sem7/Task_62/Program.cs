// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = 4;
int cols = 4;

int[,] FillArray (int row, int col)
{
    int[,] array = new int[row, col];
    int num = 0;
    int i = 0;
    int j = 0;
    bool oneToEnd = true;
    bool upToDown = true;
    int cycleCounter = 0;
    int cycleCounterOld = 0;

    while(num < row * col)
    {
        Console.WriteLine(num);
        
        if (cycleCounter == cycleCounterOld) num++;
        else cycleCounterOld = cycleCounter;
        array[i, j] = num;
        if (oneToEnd && upToDown) j++;
        else if (!oneToEnd && !upToDown) j--;
        else if (!oneToEnd && upToDown) i++;
        else if (oneToEnd && !upToDown) i--;
        if (j == col - 1 - cycleCounter) oneToEnd = false;
        if (i == row - 1 - cycleCounter) upToDown = false;
        if (j == 0 + cycleCounter) oneToEnd = true;
        if (i == 0 + cycleCounter) upToDown = true;
        if (array[i,j] != 0)
        {
            cycleCounterOld = cycleCounter;
            cycleCounter++;
            i++;
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
            if (j < array.GetLength(1) - 1) Console.Write ($"{array[i,j]:d2} ");
            else Console.Write ($"{array[i,j]:d2}|");
        }
        Console.WriteLine();
    }
}

int[,] genarr = FillArray(rows, cols);
PrintMatrix(genarr);
