// 11. Напишите программу, которая выводит
// случайное трёхзначное число и удаляет
// вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

var rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число: {rndNum}");

int CutMid (int num)
{
    int firstDig = num / 100 * 10;
    int secondDig = num % 10;
    return firstDig + secondDig;
}
int result = CutMid(rndNum);

Console.WriteLine($"Полученное двухзначное число(через метод): {result}");

Console.WriteLine($"Полученное двухзначное число: {rndNum / 100 * 10 + rndNum % 10}");