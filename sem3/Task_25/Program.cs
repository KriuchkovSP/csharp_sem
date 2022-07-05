// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Программа запрашивает 2 числа (A и B) и возводит число A в натуральную степень B");
Console.Write ("Введите число A: ");
int numA = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите число B: ");
int numB = Convert.ToInt32 (Console.ReadLine ());

int[] Pow(int a, int b)
{
    int[] res = new int[2] {1, 0};

    try
    {
        if (b == 0) return res;
        else 
        for (res[1] = 1; res[1] <= b; res[1]++)
        {
            checked
            {
                res[0] *= a;
            }
            
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Переполнение типа");
    }
    return res;
}

int[] result = Pow(numA, numB);
Console.WriteLine ($"Число {numA} в степени {result[1] - 1} равно: {result[0]}");
