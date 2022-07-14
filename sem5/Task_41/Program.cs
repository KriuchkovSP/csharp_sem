// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] InputMNum ()
{
    Console.Write("Введите количество вводимых чисел: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    int[] arrNum = new int[numM];
    for (int i = 0; i < numM; i++)
    {
        Console.Write($"Введите число: ");
        arrNum[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrNum;
}

int CheckNumMoreZero (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

void PrintRes (int num)
{
    Console.WriteLine ($"Количество чисел больше нуля {num}");
}

void PrintArr(int[] array)
{
    Console.WriteLine ("Числа, введенные пользователем:");
    for (int i = 0; i < array.Length;i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write ($"{array[i]}, ");
        else Console.WriteLine ($"{array[i]}]");
    }
}

int[] arr = InputMNum();
PrintArr (arr);
int numMoreZero = CheckNumMoreZero(arr);
PrintRes (numMoreZero);
