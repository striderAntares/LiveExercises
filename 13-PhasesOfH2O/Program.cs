using System.Linq.Expressions;
do
{
    try
    {
        Console.WriteLine("You should enter the temperature of your H2O molecules in celsius");
        int temperature = Convert.ToInt32(Console.ReadLine());
        switch (temperature)
        {
            case < 0:
                Console.WriteLine("Solid");
                break;
            case 0:
            case 100:
                Console.WriteLine("Phase change");
                break;
            case > 100:
                Console.WriteLine("Gas");
                break;
            case > 0:
                Console.WriteLine("Liquid");
                break;
        }
    }
    catch
    {
        Console.WriteLine("Try again");
    }
}
while (true);