using System.Collections;
do
{
    try
    {
        Console.WriteLine("T for tea, L for lemonade, S for soda, C for coke");
        string drinkPreferance = Console.ReadLine().ToUpper().Trim();
        switch (drinkPreferance)
        {
            case "T":
                 Console.WriteLine("Tea");
                break;
            case "L":
                 Console.WriteLine("Lemonade with chicken wings");
                break;
            case "S":
                 Console.WriteLine("Soda");
                break;
            case "C":
                 Console.WriteLine("Coke");
                break;
            default:
                 Console.WriteLine("You should try again");
                break;
        }     
 }
    catch
    {
        Console.WriteLine("You should try again");
    }
}
while (true);