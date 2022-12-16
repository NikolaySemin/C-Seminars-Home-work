// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!);
if(b == a*a)
{
    Console.WriteLine("число является квадратом первого числа");
}
else
{
    Console.WriteLine("число не является квадратом первого числа");
}