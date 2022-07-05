// Задача 28:
// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

decimal[] Mult (int num)
{
    decimal[] mul = new decimal[2] {1, 1};

    for (mul[1] = 1; mul[1] <= num; mul[1]++)
    {   
        try
        {
            checked
            {
                mul[0] *= mul[1];
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Переполнение типа!");
            break;
        }
    }
    return mul;
}  
decimal[] res = new decimal[2];
res = Mult(a);

Console.WriteLine($"Произведение чисел от 1 до {res[1] - 1} = {res[0]}");