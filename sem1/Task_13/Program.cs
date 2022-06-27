// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Программа запрашивает целое число и выводит его третью цифру или сообщает об ее отсутствии");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int ThirdDig(int number)
{
    number = Math.Abs(number); // Работаем с абсолютными значениями, чтобы отрабатывал
                               // функционал с отрицательными числами и не мешался "-"
    int digitCount = (int)Math.Log10(number) + 1; //Определяем количество разрядов
    Console.WriteLine(digitCount);
    if (digitCount < 3 ) return -1; // Третьего числа нет
    int result = number % Convert.ToInt32(Math.Pow(10, digitCount - 2)) /
             Convert.ToInt32(Math.Pow(10, digitCount - 3)); // Тут по аналогии с Task 10
    return result;
}
int result = ThirdDig(num); // Сохраняем результат вызванного метода
string output = result == -1 ? $"Введенное число {num} не имеет третьей цифры" :
 $"Третья цифра введенного числа {num}: {result}"; // Формируем строку на вывод

Console.WriteLine(output); // Вывод результата