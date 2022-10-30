//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4


Console.Write("Номер строки: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Номер стобца: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[5, 5];

int[,] GetArray(int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 20);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}

array = GetArray(m,n);

if (m > array.GetLength(0) || n > array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{                                                                    
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца равно {array[m-1, n-1]}");
}

PrintArray(array);

