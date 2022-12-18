// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);

int a = 1, b = 2, c = 3, d = 4,
    e = 5, f = 6, g = 7;

if(num == a)
{
    Console.WriteLine("Понедельник");
    Console.Write("Будний день");
}
if(num == b)
{
    Console.WriteLine("Вторник");
    Console.Write("Будний день");
}
if(num == c)
{
    Console.WriteLine("Среда");
    Console.Write("Будний день");
}
if(num == d)
{
    Console.WriteLine("Четверг");
    Console.Write("Будний день");
}
if(num == e)
{
    Console.WriteLine("Пятница");
    Console.Write("Будний день");
}
if(num == f)
{
    Console.WriteLine("Суббота");
    Console.Write("Выходной день");
}
if(num == g)
{
    Console.WriteLine("Воскресенье");
    Console.Write("Выходной день");
}
// Console.Write("Введите число от 1 до 7: ");
// int num = int.Parse(Console.ReadLine()!);

// if (num <= 5 )
// {
//     Console.WriteLine("Будний день");
// }
// else
// {
//     Console.WriteLine("Выходной");
// }
