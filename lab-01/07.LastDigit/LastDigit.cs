using System;
class LastDigit
{
    static void Main()
    {
        int n;
        int lastDigit;

        Console.Write("input number : ");
        n = int.Parse(Console.ReadLine());

        lastDigit = n % 10;
        Console.WriteLine(lastDigit);
        Console.ReadKey();
    }
}
