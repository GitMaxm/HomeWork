// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

void GetNumbers(int N)
{
    if (N == 1)
    {
        Console.WriteLine(N);
        return;
    }
    else
    {
        
        Console.WriteLine(N);
        GetNumbers(N - 1);
    }
}

GetNumbers(N);
