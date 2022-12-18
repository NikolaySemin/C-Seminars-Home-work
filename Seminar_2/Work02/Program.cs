// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите трехзначное число: ");
// int a = int.Parse(Console.ReadLine()!);
// int b = a%10;
// Console.Write("третье число у вас: ");
// Console.WriteLine(b);

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine()!);

while(true)
{
    if(a >99)
    {
        Console.Write("третье число у вас: ");
        Console.WriteLine(a.ToString()[2]);
        Console.ReadKey(true);
        break;
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
        break;
    }
}


// int n = 23456;
//         Console.WriteLine(n>99 ? n.ToString()[2] : '-');
//         Console.ReadKey(true);
