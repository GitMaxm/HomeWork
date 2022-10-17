// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите певрое число: ");
int Num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if (Num1 > Num2) 
{
    max = Num1;
    min = Num2;
}
else
{
    max = Num2;
    min = Num1;
}
Console.WriteLine("Max: " + max + " Min: " + min); 