// See Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
Console.WriteLine();
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
bool isInNumber = false;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == number)
        {
            Console.WriteLine($"{(i, j)}");
            isInNumber = true;
        }
        else
        {
            isInNumber = false;
        }
    }
}
if (isInNumber)
{
    Console.WriteLine();
}
else
{
    Console.Write("Данного числа в двумерном массиве нет");
}