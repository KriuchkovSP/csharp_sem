// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ConvDec (int num, int baseNum)
{
    int res = 0;
    int  d10 = 1;
    do
    {
        res += (num % baseNum) * d10;
        num /= baseNum;
        d10 *= 10;
    } while (num > 0);
    return res;
}

void ToBaseNum(int n, int baseNum)
{
    if (n == 0) return;
    ToBaseNum(n / baseNum, baseNum);
    Console.Write(n % baseNum);
}


void PrintRes (int num, int res)
{
    Console.WriteLine ($"Результат конвертирования числа {num} в двоичную систему счисления: {res}");
}

Console.Write ("Введите число для перевода: ");
int number = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите основание системы счисления: ");
int baseNumber = Convert.ToInt32(Console.ReadLine ());

int result = ConvDec(number, baseNumber);
PrintRes(number, result);
Console.WriteLine("Конвертирование рекусрией:");
ToBaseNum(number, baseNumber);
Console.WriteLine();
