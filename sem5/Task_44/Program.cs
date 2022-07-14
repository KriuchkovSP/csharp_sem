// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



int[] Fibbo (int num)
{
    int first = 0;
    int second = 1;

    int[] array = new int[num];
    array[0] = first;
    array[1] = second;

    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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

Console.Write ("Введите количество чисел Фибоначчи для вывода: ");
int number = Convert.ToInt32(Console.ReadLine ());

int[] arr = Fibbo(number);
PrintArr(arr);