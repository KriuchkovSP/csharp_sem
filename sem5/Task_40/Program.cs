// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write ("Введите первую сторону треугольника: ");
int sta = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите вторую сторону треугольника: ");
int stb = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите третью сторону треугольника: ");
int stc =  Convert.ToInt32(Console.ReadLine ());

bool CheckTriacl (int a, int b, int c)
{
    if (a  > b + c) return false;
    if (b > a + c) return false;
    if (c > a + b) return false;
    return true;
}

void PrintResult (bool res)
{
    string output = res?"Данный треугольник существует":"Данный треугольник существовать не может";
    Console.WriteLine (output);
}

bool check = CheckTriacl (sta, stb, stc);
PrintResult(check);
