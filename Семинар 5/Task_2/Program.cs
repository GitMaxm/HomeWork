// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, -7, 23, 12] -> 19

int[] GenerateRandomArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}

void ShowArray(int[] Array1)
{
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.WriteLine(Convert.ToString(Array1[i]));
    }
}


int CountOfEven(int[] myArray2)
{

    int sum = 0;
    for (int i = 0; i < myArray2.Length; i++)
        if (myArray2[i] % 2 != 0)
        {
            sum = sum + myArray2[i];
        }
    return sum;
}

int[] myArray = new int[5];
myArray = GenerateRandomArray(5, -10, 20);
ShowArray(myArray);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях " + CountOfEven(myArray));
