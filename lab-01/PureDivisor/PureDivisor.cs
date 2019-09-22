using System;
class PureDivisor
{
    static void Main()
    {
        int n;
        bool result;

        Console.Write("input number : ");
        n = int.Parse(Console.ReadLine());

        result =  n % 9 == 0 || n % 11 == 0 || n % 13 == 0;



        Console.WriteLine(result);
        Console.ReadKey();
    }
}



