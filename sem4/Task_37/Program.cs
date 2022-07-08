// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21 


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

int[] MulArrEl (int[] array)
{
    int len = 0;
    if (array.Length % 2 == 0) len = array.Length / 2;
    else len = array.Length / 2 + 1;
    int[] ResArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        ResArr[i] = array[i] * array[array.Length - 1 - i]; 
    }
    if (array.Length % 2 != 0) ResArr[len - 1] = array[len - 1];

    return ResArr;
}

Console.Write ("Введите размер массива: ");

int insize = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите максимальное число диапазона: ");
int max =  Convert.ToInt32(Console.ReadLine ());

int[] genarr = CreateArrayRndInt(insize, min, max);
int[] resArr = MulArrEl(genarr);

PrintArr(genarr);
PrintArr(resArr);
