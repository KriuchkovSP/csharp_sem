// Задача 60:
// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrixRndInt(int row, int col, int page, int begin, int end)
{
    int[,,] array = new int[row, col, page];
    Random rnd = new Random();
    int tempNum = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < page; k++)
            {
                tempNum = rnd.Next(begin, end + 1);
                bool checkNumber = CheckUniqNum(array: array, num: tempNum);
                while (!checkNumber)
                {
                    tempNum = rnd.Next(begin, end + 1);
                    checkNumber = CheckUniqNum(array: array, num: tempNum);
                }
                array[i, j, k] = tempNum;
            }
        }
    }
    return array;
}

bool CheckUniqNum (int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

bool CheckAvailableRange (int row, int col, int page, int begin, int end)
{
    if (col * row * page <= end - begin + 1) return true;
    return false;
}

void PrintArray(int[,,] array)
{
    Console.WriteLine($"Сгенерированная матрица:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i,j,k]} ({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }
}

Console.Write ("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите глубину массива (кол-во страниц): ");
int pages = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите минимальное число диапазона: ");
int minD = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите максимальное число диапазона: ");
int maxD =  Convert.ToInt32(Console.ReadLine ());

bool checkRange = CheckAvailableRange(rows, cols, pages, minD, maxD);
if (checkRange)
{
    int[,,] genarr = CreateMatrixRndInt(rows, cols, pages, minD, maxD);
    PrintArray(genarr);
}
else Console.WriteLine("Заполнение массива невозможно, поскольку доступный диапазон чисел меньше количества элементов массива");

