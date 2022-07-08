// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

void PrintResult(int result)
{
    Console.WriteLine($"Количество четных чисел в массиве {result}");
}

int GetParity(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write ("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine ());
// Console.Write ("Введите минимальное число диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine ());
// Console.Write ("Введите максимальное число диапазона: ");
// int max =  Convert.ToInt32(Console.ReadLine ());
int min = 100;
int max = 999;

int[] genarr = CreateArrayRndInt(insize, min, max);
int res = GetParity(genarr);

PrintArr(genarr);
PrintResult(res);
