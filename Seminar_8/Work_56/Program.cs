// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
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

int SumRowElements(int[,] matr, int i)
{
    int sumRow = matr[i, 0];
    for (int j = 1; j < matr.GetLength(1); j++)
    {
        sumRow += matr[i, j];
    }
    return sumRow;
}

Console.Clear();
Console.WriteLine("Введите количетво столбцов прямоугольного массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количетво строк прямоугольного массива: ");
int m = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int minSumRow = 0;
int sumRow = SumRowElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumRow = SumRowElements(matrix, i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}

Console.WriteLine($" Строкa с наименьшей суммой элементов => {minSumRow + 1} ");
Console.WriteLine($" Наименишая сумма элементов = {sumRow}");






