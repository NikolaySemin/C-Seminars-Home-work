// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
int a = new Random().Next(10, 99);
Console.WriteLine(a);

if (a > 10 && a < 99)
{
if (a / 10 > a % 10)
{
        Console.WriteLine("Первая цифра больше");
}

else

if (a / 10 == a % 10)
{
        Console.WriteLine("Цифры одинаковы");
}
else
Console.WriteLine("Вторая цифра больше");
}
