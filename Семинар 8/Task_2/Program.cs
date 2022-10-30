//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] array = new int[3, 5];


int[,] GetArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
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

array = GetArray();


int MinSum(int[,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minsum = minsum + array[0, i];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}

Console.WriteLine($"Строка с наименьшей суммой - {MinSum(array)}");
PrintArray(array);

