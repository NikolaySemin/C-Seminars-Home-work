// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// (читается слева направо и справа налево одинаково)

Console.WriteLine("Введите число: ");
string num = Console.ReadLine()!;
int len = num.Length;
for (int i = 0; i < len/2; i++)
{
    if (num[i] !=num[len -i-1])
    {
        Console.WriteLine("Число не является палиндромом");
        break;
    }
    else
    {
        Console.WriteLine("Число является палиндромом");
    }
}
