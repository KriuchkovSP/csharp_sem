// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArrayRndDoub (int size, int begin, int end)
{
    double[] array = new double[size];
    double tempgen = 0.0;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        tempgen = rnd.NextDouble() * (end - begin) + begin;
        array[i] = Math.Round(tempgen, 2);
    }
    return array;
}

void PrintArr(double[] array)
{
    Console.WriteLine ($"Сгенерированный массив из {array.Length} элементов:");
    for (int i = 0; i < array.Length;i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
        else Console.WriteLine ($"{array[i]}]");
    }
}

void PrintMinMaxEl(double min, double max)
{
    Console.WriteLine($"Минимальный элемент массива {min}");
    Console.WriteLine($"Максимальный элемент массива {max}");
}

void PrintResult(double result)
{
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {result}");
}

double[] GetMinMaxEl (double[] array)
{
    int minPosEl = 0;
    int maxPosEl = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxPosEl]) maxPosEl = i;
        else if (array[i] < array[minPosEl]) minPosEl = i;
    }
    return new[] {array[minPosEl], array[maxPosEl]};
}

double DiffMaxMin(double min, double max)
{
    return Math.Round(max - min, 2);
}

Console.Write ("Введите размер массива: ");
int insize = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите минимальное число диапазона: ");
int minD = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите максимальное число диапазона: ");
int maxD =  Convert.ToInt32(Console.ReadLine ());

double[] genarr = CreateArrayRndDoub(insize, minD, maxD);
double[] minMaxEl = GetMinMaxEl(genarr);
double minEl = minMaxEl[0];
double maxEl = minMaxEl[1];
double res = DiffMaxMin(minEl, maxEl);

PrintArr(genarr);
PrintMinMaxEl(minEl, maxEl);
PrintResult(res);
