// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    Console.WriteLine($"Сумма элементов на нечетных позициях: {result}");
}

int GetSumNParEl (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write ("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите максимальное число диапазона: ");
int max =  Convert.ToInt32(Console.ReadLine ());

int[] genarr = CreateArrayRndInt(insize, min, max);
int res = GetSumNParEl(genarr);

PrintArr(genarr);
PrintResult(res);
