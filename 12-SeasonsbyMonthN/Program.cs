﻿using System.Linq.Expressions;
do
{
    try
    {
        Console.WriteLine("Enter month number get the season");
        int monthN = Convert.ToInt16(Console.ReadLine());
        switch (monthN)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Winter");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Spring");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Summer");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Fall");
                break;
            default:
                Console.WriteLine("Try again");
                break;
        }
    }
    catch
    {
        Console.WriteLine("Try again");
    }
}    
while (true);
