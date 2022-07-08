// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int SearchElem (int[] array, int begin, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= begin && array[i] <= end) count++;
    }
    return count;
}

int[] CreateArrayRndInt (int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.WriteLine ($"Сгенерированный массив из {array.Length} элементов:");
    for (int i = 0; i < array.Length;i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
        else Console.WriteLine ($"{array[i]}]");
    }
}

void PrintRes(int res)
{
    Console.WriteLine ($"Количество элементов массива, входящих в диапазон [10...99]: {res}");
}

Console.Write ("Введите размер массива: ");

int insize = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите максимальное число диапазона: ");
int max =  Convert.ToInt32(Console.ReadLine ());

int[] genarr = CreateArrayRndInt(insize, min, max);

int result = SearchElem(genarr, 10, 99);

PrintArr(genarr);
PrintRes(result);
