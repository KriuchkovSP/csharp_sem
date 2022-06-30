// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Программа запрашивает пятизначное число и проверяет, является ли оно палиндромом");
Console.Write ("Введите пятизначное число: ");
int num = Convert.ToInt32 (Console.ReadLine());

int Palindrom (int n)
{
    if (n < 9999 || n > 99999) return -1;
    int[] n_to_mas = new int [5];
    int i = 0;
    while (i < 5)
    {
        n_to_mas [i] = n % 10;
        n = n / 10;
        i++;
    }
    i = 0;
    while (i < 5 / 2)
    {
        if (n_to_mas[i] != n_to_mas[4 - i]) return 0;
        i++;
    }
    return 1;
}
int res = Palindrom(num);
string output = "";
switch (res)
{
    case 0:
        output = "не является палиндромом";
        break;
    case 1:
        output = "является палиндромом";
        break;
    default:
        output = "не является пятизначным числом";
        break;
}
Console.WriteLine($"Введеное число {num} {output}");


/*

//Универсальная программа, для любых введеных чисел

Console.WriteLine ("Программа запрашивает число и проверяет, является ли оно палиндромом");
Console.Write ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine());

bool PalindromUniv (int n)
{
    if (n < 0) return false;
    int digitCount = 1;
    if (n != 0) digitCount = (int)Math.Log10(n) + 1; //Определяем количество разрядов
    Console.WriteLine(digitCount);
    int[] n_to_mas = new int [digitCount];
    int i = 0;
    while (i < digitCount)
    {
        n_to_mas [i] = n % 10;
        n = n / 10;
        i++;
    }
    i = 0;
    while (i < digitCount / 2)
    {
        if (n_to_mas[i] != n_to_mas[digitCount - 1 - i]) return false;
        i++;
    }
    return true;
}
bool result = PalindromUniv(num);
string output = (result) ? "является палиндромом" : "не является палиндромом";

Console.WriteLine($"Введеное число {num} {output}"); //Является ли 0 палиндромом???

*/