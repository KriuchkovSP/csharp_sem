// 3. Напишите программу, которая будет выдавать название дня недели
// по заданному номеру. 3 -> Среда 5 -> Пятница

Console.Write("Введите день недели числом: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Введенный день недели: Понедельник");
        break;
    case 2:
        Console.WriteLine("Введенный день недели: Вторник");
        break;
    case 3:
        Console.WriteLine("Введенный день недели: Среда");
        break;
    case 4:
        Console.WriteLine("Введенный день недели: Четверг");
        break;
    case 5:
        Console.WriteLine("Введенный день недели: Пятница");
        break;
    case 6:
        Console.WriteLine("Введенный день недели: Суббота");
        break;
    case 7:
        Console.WriteLine("Введенный день недели: Воскресенье");
        break;
    default:
        Console.WriteLine("Введен некорректный день недели");
        break;
}