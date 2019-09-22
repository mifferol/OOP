using System;
class Average
{
    static void Main()
    {
        int a;
        int b;
        int c;
        double average;

        Console.Write("input a : ");
        a = int.Parse(Console.ReadLine());
        Console.Write("input b : ");
        b = int.Parse(Console.ReadLine());
        Console.Write("input c : ");
        c = int.Parse(Console.ReadLine());

        average = (a + b + c) / 3.0;

        Console.WriteLine(average);
        Console.ReadKey();
    }
}
