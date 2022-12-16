// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите первое число: ");
Double a = Double.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
Double b = Double.Parse(Console.ReadLine()!);


   if ( a % b == 0 )
   {
        Console.Write("Первое число кратно второму, остаток: ");
   }
   else
   {
    Console.Write("Первое число не кратно второму, остаток: ");
    Console.WriteLine(a/b);
   }