do
{
    try
    {
        Console.WriteLine("Enter a text without numbers");
        string txt = Console.ReadLine().Trim();
        int j = 0;
        while (j < 10)
        {
            txt = txt.Replace(j.ToString(),"");
            Console.WriteLine("Purged= " + txt);
            j++;
        }
        Console.WriteLine("Enter a number which is bigger than 1");
        int repeatCount = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i < repeatCount)
        {
            i++;
            Console.WriteLine(txt);
        }
        if (i > repeatCount)
                {
                    Console.WriteLine("That's illegal");
                }
    }
    catch
    {
        Console.WriteLine("Try again");
    }
}
while (true);