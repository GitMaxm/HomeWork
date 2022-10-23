// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int[] creatArray()
{
    int[] ints = new int[8];
    Random random = new Random();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = random.Next();
    }
    return ints;
}

string GetArrayAsString(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i].ToString()}, ";
    }
    return result;
}

Console.WriteLine(GetArrayAsString(creatArray()));