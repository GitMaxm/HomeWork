// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"Индексы: i: {i}, j: {j}, k: {k}. Значение: {matrix[i, j, k]} ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array3D = CreateMatrix(3, 3, 1, 10, 99);
PrintMatrix(array3D);
