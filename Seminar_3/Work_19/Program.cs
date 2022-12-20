// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// (читается слева направо и справа налево одинаково)
class PalindromTest
{
    public static bool Palindrom(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)

            if (s[i] != s[s.Length - i - 1])
                return false;
        return true;
    }

    static void Main()
    {
        string s;
        Console.WriteLine("Анализ палиндромов\n\nВведите строку:");
        s = Console.ReadLine()!;
        if (Palindrom(s))
            Console.WriteLine("Эта строка - палиндром");
        else Console.WriteLine("Эта строка - не палиндром");
    }
}
