// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] 

Console.WriteLine("Программа запрашивает размер массива и выводит массив заданного рамера случайными числами от 0 до 1");
Console.Write ("Введите размер мaссива: ");
int insize = Convert.ToInt32 (Console.ReadLine ());

int[] resarr = new int[insize];
Random rnd = new Random();

int[] GenArr (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size;i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.WriteLine ("Результат заполнения массива случайными числами от 0 до 1:");
    for (int i = 0; i < array.Length;i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
        else Console.WriteLine ($"{array[i]}]");
    }
}

resarr = GenArr(insize);
PrintArr(resarr);
