// По заданному номеру дня недели вывести его название
Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(num == a)
{
    Console.WriteLine("Понедельник");
}
if(num == b)
{
    Console.WriteLine("Вторник");
}
if(num == c)
{
    Console.WriteLine("Среда");
}
if(num == d)
{
    Console.WriteLine("Четверг");
}
if(num == e)
{
    Console.WriteLine("Пятница");
}
if(num == f)
{
    Console.WriteLine("Суббота");
}
if(num == g)
{
    Console.WriteLine("Воскресенье");
}
