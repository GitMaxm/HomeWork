// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int Num2 = 0;
    // int Num1 = 0;
    // int Num3 = 0;

    //Num1 = number / 100;
    Num2 = number / 10 % 10;
    //Num3 = number % 10;

    Console.WriteLine("Вторая цифра: " + Num2);
}
else
{
    Console.WriteLine(" Число не трехзначное ");
}
