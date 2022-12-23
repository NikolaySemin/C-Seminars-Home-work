// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + "]");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
}

int[] array = new int[5];
FillRandomArray(array);
Console.Write("массив: ");
PrintArray(array);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($" => {max - min} <= разница между минимальным и максимальным элементом массива.");

