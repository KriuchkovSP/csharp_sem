// Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int i = 0;
int[] nummas = new int[3];
int max_pos = 0;
Console.WriteLine("Программа запрашивает 3 целых числа и выдает максимальное из них");
while (i < 3)
{
    Console.Write($"Введите {i + 1} целое число: ");
    nummas[i] = Convert.ToInt32(Console.ReadLine());
    if (nummas[max_pos] < nummas[i]) max_pos = i;
    i++;
}

Console.WriteLine($"Введенное максимальное число: {nummas[max_pos]}");