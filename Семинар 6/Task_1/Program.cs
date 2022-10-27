//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите колличество элементов массива: ");
int size = int.Parse(Console.ReadLine());
int[] myArray = new int[size];
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент масива под индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]} ");
}

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        sum++;
    }
}
Console.ReadLine();
Console.WriteLine($"Чисел больше нуля: {sum}");
