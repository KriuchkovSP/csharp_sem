// Задача 50.
// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

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

void SearchElem (int[,] array, int[] pos)
{
    if (pos[0] < array.GetLength(0) && pos[1] < array.GetLength(1))
    {
        // - 1 чтобы было удобно человеку, начинающему отсчет с 1
        Console.WriteLine($"Элемент с позицией {pos[0]} {pos[1]} равен {array[pos[0] - 1, pos[1] - 1]}");
    }
    else
    {
        Console.WriteLine("Числа с такой позицией в массиве нет");
    }
}

Console.Write ("Введите количество позицию элемента в двумерном массиве через пробел (например 2 3): ");
int[] position = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[,] arrayResult = CreateMatrixRndInt(4, 4, 0, 99);
PrintMatrix(arrayResult);
SearchElem(arrayResult, position);
