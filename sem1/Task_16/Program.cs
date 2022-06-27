// 16. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет 

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool sqr (int a, int b)
{
    if (num1 * num1 == num2 || num2 * num2 == num1) return true;
    return false;
}

bool result = sqr (num1, num2);

string output = result ? "Одно число является квадратом другого" : "Одно число не является квадратом другого";

Console.WriteLine (output);
