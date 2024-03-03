do
{
    try
    {
        const int full = 160;
        const int discounted = 130;
        Console.WriteLine("Discounted:");
        int discountedCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Full");
        int fullCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(discounted * discountedCount + full * fullCount);

        Console.WriteLine("KDV hesaplamak ister misin?");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(d + d * 0.2);
    }
    catch
    {
        Console.WriteLine("You should try again");
    }
}
while (true);