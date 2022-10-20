// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//result = Math.Sqrt((x2-x1)^2 +(y2-y1)^2 +(z2-z1)^2)


Console.Write("Enter X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Enter Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Enter Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Enter X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Enter Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Enter Z2: ");
int z2 = int.Parse(Console.ReadLine());

//int A = x2 - x1;
//int B = y2 - y1;
//int C = z2 - z1;

// double length = Math.Sqrt(A * A + B * B + C * C);

double length = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));


Console.WriteLine(($"Длинна отрезка: {length}"));


