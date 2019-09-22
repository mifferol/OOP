using System;
class Average
{
    static void Main()
    {
        double a;
        double b;
        double h;
        double area;

        Console.Write("input a : ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("input b : ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("input h : ");
        h = Convert.ToDouble(Console.ReadLine());

        area = (a + b) / 2.0 * h;

        Console.WriteLine(area);
        Console.ReadKey();
    }
}
