// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.Write("Введите число от 1 до 7: ");
// int num = int.Parse(Console.ReadLine()!);

// int a = 1;
// int b = 2;
// int c = 3;
// int d = 4;
// int e = 5;
// int f = 6;
// int g = 7;

// if(num == a)
// {
//     Console.WriteLine("Понедельник");
//     Console.Write("не выходной день");
// }
// if(num == b)
// {
//     Console.WriteLine("Вторник");
//     Console.Write("не выходной день");

// }
// if(num == c)
// {
//     Console.WriteLine("Среда");
//     Console.Write("не выходной день");

// }
// if(num == d)
// {
//     Console.WriteLine("Четверг");
//     Console.Write("не выходной день");

// }
// if(num == e)
// {
//     Console.WriteLine("Пятница");
//     Console.Write("не выходной день");

// }
// if(num == f)
// {
//     Console.WriteLine("Суббота");
//     Console.Write("выходной день");

// }
// if(num == g)
// {
//     Console.WriteLine("Воскресенье");
//     Console.Write("выходной день");

// }
Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);

if (num <= 5 )
{
    Console.WriteLine("будни");
}
else
{
    Console.WriteLine("выходной");
}