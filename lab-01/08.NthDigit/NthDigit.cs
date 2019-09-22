using System;
class NthDigit
{
    static void Main()
    {
        int number;
        int n;
        int nDigit;

        Console.Write("input number : ");
        number = int.Parse(Console.ReadLine());

        Console.Write("input n : ");
        n = int.Parse(Console.ReadLine());

        nDigit = Convert.ToInt32(number / Math.Pow(10, n - 1) % 10.0);
        Console.WriteLine(nDigit);
        Console.ReadKey();
    }
}