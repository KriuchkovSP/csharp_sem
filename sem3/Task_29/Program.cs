// Задача 29: Напишите программу, которая задаёт массив из 8 элементов,
// заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Размер массива задает пользователь
// Console.WriteLine("Программа запрашивает размер массива и выводит " 
//                 + "массив заданного размера, заполненного случайными числами");
// Console.Write ("Введите размер мaссива: ");
// int insize = Convert.ToInt32 (Console.ReadLine ());

// Фиксированный размер массива, как по заданию - 8 элементов
Console.WriteLine("Программа выводит массив фиксированного размера, заполненного случайными числами");

int insize = 8;
int[] resarr = new int[insize];
Random rnd = new Random();

int[] GenArr (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size;i++)
    {
        array[i] = rnd.Next(-99, 100); // Ограничим от -99 до 99, чтобы не пугать большими числами,
                                       // без ограничений использовать rnd.Next();
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.WriteLine ("Результат заполнения массива случайными числами:");
    for (int i = 0; i < array.Length;i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
        else Console.WriteLine ($"{array[i]}]");
    }
}

resarr = GenArr(insize);
PrintArr(resarr);
