// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!);
if(b == a*a)
{
    Console.Write("число является квадратом: ");
    Console.WriteLine(a);
}
else
{
    Console.Write("число не является квадратом: ");
    Console.WriteLine(a);
}