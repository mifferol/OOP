using System;
class Factorial
{
    static void Main()
    {

        int n;
        int factorial = 1;

        Console.Write("input n : ");
        n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
            factorial *= i;

        Console.WriteLine(factorial);
        Console.ReadKey();



    }
}
