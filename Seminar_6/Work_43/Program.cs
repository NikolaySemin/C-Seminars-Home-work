// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Формулы нахождения координат x и y точки пересечения:
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("ВВедите число b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("ВВедите число k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("ВВедите число b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("ВВедите число k2: ");
double k2 = double.Parse(Console.ReadLine()!);

double x = (b2 - b1) / (k2 - k1);
double y = k1 * x - b1;    // если оставить как в первоначальной формуле "y = k1*x+b1;" выдает неверные координаты (4,5) вместо (0,5)
Console.WriteLine($"({x};{y})");
