do
{
    try
    { 
    Console.WriteLine("Enter 10 numbers, see which is bigger, which is smaller");
    int max = 0;
    int min = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Number " + (i + 1) + ":");
        int k = Convert.ToInt32(Console.ReadLine());
            
        if (k > max || max == 0)
            max = k;
        if (k < min || min == 0) 
            min = k;
    }
    Console.WriteLine("Max value = " + max + " Min value = " + min);
    }
    catch 
    {
        Console.WriteLine("Try again");
    }
}
while (true);