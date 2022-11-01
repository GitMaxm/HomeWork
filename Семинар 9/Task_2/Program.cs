// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;

void GetNumbersMN(int M, int N)
{
    if (N >= M)
    {
        if (N == M)
        {
            Console.WriteLine(N);
            return;
        }
        else
        {
            GetNumbersMN(M, N - 1);
            Console.WriteLine(N);
        }
    }
    else Console.WriteLine($"{M} > {N} введите правильные данные");
}
GetNumbersMN(M, N);

void PrintSum(int M, int N, int sum)
{
    sum = sum + M;
    if (M <= N)
    {
        Console.Write($"Сумма натуральных элементов: {sum}");
        return;
    }
    PrintSum(M, N - 1, sum);
}

PrintSum(M, N - 1, sum);
