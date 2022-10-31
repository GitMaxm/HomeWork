// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];



int[,] GetArray1()
{
    Random rnd = new Random();
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = rnd.Next(1, 10);
        }
    }
    Console.WriteLine("Первая матрица: ");
    return array1;

}

void PrintArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} ");
        }
        Console.WriteLine();
    }

}




int[,] GetArray2()
{
    Random rnd = new Random();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = rnd.Next(1, 10);
        }
    }
    Console.WriteLine("Вторая матрица: ");
    return array2;
}

void PrintArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }

}

array1 = GetArray1();
PrintArray1(array1);
array2 = GetArray2();
PrintArray2(array2);

int[,] DivMatrix(int[,] array1, int[,] array2)
{
    int[,] m = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); ++i)
        for (int j = 0; j < array2.GetLength(0); ++j)
            for (int k = 0; k < array2.GetLength(1); ++k)
                m[i, k] += array1[i, j] * array2[j, k];
    return m;
}

int[,] m = DivMatrix(array1, array2);
Console.WriteLine($"Сумма матриц: {m}");