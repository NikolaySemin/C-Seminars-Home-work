// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a/10%10;
Console.Write("второе число у вас: ");
Console.WriteLine(b);


// Console.WriteLine("Введите трехзначное число.\n Для выхода из программы введите q.");
//     while(true)
//     {
//         string input = Console.ReadLine()!;
//         if(!input.Equals("q")!)
//             Console.WriteLine("{0}->{1}",input, input[1]);
//         else
//             break;
//     }
