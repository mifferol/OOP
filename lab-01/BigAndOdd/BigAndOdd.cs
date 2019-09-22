using System;
class BigAndOdd
{
    static void Main()
    {
        int n;
        bool result;

        Console.Write("input number : ");
        n = int.Parse(Console.ReadLine());

        result = n > 20 && n % 2 == 1;



        Console.WriteLine(result);
        Console.ReadKey();
    }
}
   

