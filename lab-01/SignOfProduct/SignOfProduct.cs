using System;
class SignOfProduct
{
    static void Main()
    {
        Console.Write("input 3 digit  : ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if( (a < 0 && b < 0 && c < 0)  || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("positive");
        }
            Console.ReadKey();



    }
}
