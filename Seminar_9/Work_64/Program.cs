﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumber(n));

string PrintNumber(int n)
{
    if (n == 1) return "1";
    return (n + " " + PrintNumber(n - 1));
}