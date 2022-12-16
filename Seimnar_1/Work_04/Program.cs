// Выяснить является ли число чётным
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a%2==0)
{
    Console.WriteLine("четное число ");
}
else
{
    Console.WriteLine("нечетное число ");
}