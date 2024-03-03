do
    { 
    try
        { 
        Console.WriteLine("T for tea, L for lemonade, S for soda, C for coke");
        string drinkPreferance = Console.ReadLine().ToUpper().Trim();
        if (drinkPreferance == "T")
            Console.WriteLine("Tea");
        else if (drinkPreferance == "L")
            Console.WriteLine("Lemonade");
        else if (drinkPreferance == "S")
            Console.WriteLine("Soda");
        else if (drinkPreferance == "C")
            Console.WriteLine("Coke");
        else
            Console.WriteLine("Try again");
        }
    catch 
        {
        Console.WriteLine("You should try again");
        }
    }
while (true);