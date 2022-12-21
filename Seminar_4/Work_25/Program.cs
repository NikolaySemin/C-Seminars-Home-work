// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!

Console.WriteLine("Введите число А:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B:");
int b = int.Parse(Console.ReadLine()!);

int sum = 1;
for (int i = 0; i < b; i++)
{
    sum=sum*a;
}
Console.WriteLine(sum);