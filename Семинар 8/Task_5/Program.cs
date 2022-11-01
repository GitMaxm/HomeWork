// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = new int[4, 4];

int[,] CreatArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 20);
        }
    }
    Console.WriteLine("Массив: ");
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

array = CreatArray();
PrintArray(array);

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= array.GetLength(0) * array.GetLength(1))
// {
//     array[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= array.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > array.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }

// Console.WriteLine("Спираль: " + array);