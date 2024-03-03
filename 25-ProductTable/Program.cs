using System;

public class Program
{
    public static void Main()
    {
        //7 product table
        int i = 0;
        int j = 7;
        Console.WriteLine("Product table:");
        while (i <= 9)
        {
            Console.WriteLine($"{i}*{j}={i * j}");
            i++;
        }

        //Enter the number get the number and its square until you type 0
        Console.WriteLine("Enter a number get it and its square. Type 0 if you want to quit");
        int k = 0;
        do
        {
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number an its square= " + k + " " + k * k);
        }
        while (k != 0);

    //do product for two numbers user entered but by summing
    beginning:
        Console.WriteLine("Enter two numbers see their product");
        int l = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int n = 1;
        int o = 0;
        if (m >= 0 && l >= 0)
        {
            while (n <= l)
            {
                o = o + m;
                n++;
            }
            Console.WriteLine("Product = " + o);
        }
        else
        {
            goto beginning;
        }

        //take 10 numbers from user, print the numbers which can be divided by 3 by 5 and by both
        Console.WriteLine("You shall enter 10 numbers. And see how many of them can be divided by 3, 5 or both");
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        string dizi = "List: ";
        string dizi1 = "List: ";
        string dizi2 = "List: ";
        for (int n4 = 1; n4 <= 10; n4++)
        {
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 % 3 == 0)
            {
                count1++;
                dizi = dizi + (n2 + " ,");
            }
            if (n2 % 5 == 0)
            {
                count2++;
                dizi1 = dizi1 + (n2 + " ,");
            }
            if (n2 % 3 == 0 && n2 % 5 == 0)
            {
                count3++;
                dizi2 = dizi2 + (n2 + " ,");
            }
        }
        Console.WriteLine("How many numbers can be divided by 3= " + count1 + " How many can be divided by 5= " + count2 + " By both= " + count3);
        Console.WriteLine("By 3= " + dizi.TrimEnd(',') + "\nBy 5= " + dizi1.TrimEnd(',') + "\nBy both= " + dizi2.TrimEnd(','));


        //password is 123 repeat it until it is correct
        Console.WriteLine("It will loop until you type 123");
        string txt = "password";
        while (txt != "123")
            txt = Console.ReadLine();

        //user enters number how many of them are 3 digits?
        Console.WriteLine("You shall enter 10 numbers program will tell you how many of them have 3 digits");
        int y = 1;
        int counterr = 0;
        do
        {
            Console.WriteLine("Number" + y);
            int x = Convert.ToInt32(Console.ReadLine());
            y++;
            if (x > 99 && x < 1000)
            {
                counterr++;
            }
        }
        while (y <= 10);
        Console.WriteLine(counterr);

        //if user enters q or Q break the loop

        Console.WriteLine("It will loop until you type q or Q");
        string txt2 = "loopyloop";

        do
        {
            txt2 = Console.ReadLine().ToLower().Trim();
            if (txt2 == "q")
                break;
        }
        while (true);

        //user enters numbers until he types 0. numbers he type must not match consequently end sum them
        Console.WriteLine("It will sum all the numbers you enter until you type 0. Consequent numbers you enter can't match.");
        int u = 1;
        int total = 0;
        int b = 0;
        do
        {
            u = Convert.ToInt32(Console.ReadLine());
            if (b != u)
            {
                b = u;
                total = total + u;
            }
            Console.WriteLine(total);
        }
        while (u != 0);
    }

}



