// Удалить вторую цифру трёхзначного числа.
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int b = a / 100 * 10 + a % 10;
Console.Write("Без второго числа выглядит так: ");
Console.WriteLine(b);