// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6


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

int[,] matrix1 = new int[2,2];
FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = new int[2,2];
FillMatrix(matrix2);
PrintMatrix(matrix2);

int[,] resultMatrix = new int[2,2];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = matrix1[i,j]*matrix2[i,j];
        }
    
    }
    Console.WriteLine("Результирующая матрица будет:");
    PrintMatrix(resultMatrix);

