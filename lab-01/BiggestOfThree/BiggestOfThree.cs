using System;
class BiggestOfThree
{
    static void Main()
    {
        int a, b, c;

        Console.Write("input number a : ");
        a = int.Parse(Console.ReadLine());
        Console.Write("input number b : ");
        b = int.Parse(Console.ReadLine());
        Console.Write("input number c : ");
        c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.Write("Number a is the largest\n");
            }
            else
            {
                Console.Write("Number c is the largest\n");
            }
        }

        else if (b > c)
            Console.Write("Number b is the largest\n");
        else
            Console.Write("Number c is the largest\n");
        Console.ReadKey();
    }
}

