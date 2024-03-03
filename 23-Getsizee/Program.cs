do
{ 
    try
    { 
    Console.WriteLine("Vertical side= ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Horizontal side= ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i>0 && j> 0)
    { 
        for (int k = 1; k<=i; k++)
        {
            for (int t = 1; t<=j; t++)
            { 
                Console.Write("#"); 
            }
        Console.Write("\n");
        }
    }
    else if (i < 0 || j < 0)
    { 
        Console.WriteLine("That is illegal"); 
    }
    }
    catch 
    {
        Console.WriteLine("Try again");
    }
}
while (true);