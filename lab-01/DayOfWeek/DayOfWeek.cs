﻿using System;
class DayOfWeek
{
    static void Main()
    {
        int n;

        Console.Write("input number of a day : ");
        n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("not valid!");
                break;
        }

        Console.ReadKey();
    }
}