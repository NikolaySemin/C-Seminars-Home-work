// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите число A: ");
double a = double.Parse(Console.ReadLine()!);
Console.Write("Введите число A1: ");
double a1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите число A2: ");
double a2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
double b = double.Parse(Console.ReadLine()!);
Console.Write("Введите число B1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите число B2: ");
double b2 = double.Parse(Console.ReadLine()!);


double ab = Math.Sqrt(Math.Pow(a-b,2)+Math.Pow(a1-b1,2)+Math.Pow(a2-b2,2));

Console.WriteLine(ab);
