// Задача 61
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

int CalcTrianglePascal (int row, int pos)
{
    int num = 1;
    int i = 0;
    if (row - pos > pos) pos = row - pos;
    for (i = pos + 1; i <= row; i++) num = num * i;
    for (i = 1; i < (row - pos + 1); i++) num = num / i;
    return num;
}

void PrintTrianglePascal (int row)
{
    Console.Clear();
    int num = 1;
    for (int i = 0; i < row; i++)
    {
        Console.SetCursorPosition(50 - 2 * i, i);
        for (int j = 0; j <= i ; j++)
        {
            num = CalcTrianglePascal(i,j);
            Console.Write($"{num,4}");
        }
        Console.WriteLine();
    }
}

Console.Write ("Введите количество строк треугольника Паскаля: ");
int rows = Convert.ToInt32(Console.ReadLine ());

PrintTrianglePascal(rows);
