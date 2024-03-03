do
{
    Console.WriteLine("Write your salary");
    int salary = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many kids you got?");
    int kid = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Are you married? Type Yes or No");
    string marriage = Console.ReadLine().ToLower().Trim();
    if (marriage == "yes" && kid == 0)
    {
        Console.WriteLine(salary * 103 / 100);
    }
    else if (marriage == "yes" && kid == 1)
    {
        Console.WriteLine(salary * 105 / 100);
    }
    else if (marriage == "yes" && kid == 2)
    {
        Console.WriteLine(salary * 110 / 100);
    }
    else if (marriage == "yes" && kid <= 3)
    {
        Console.WriteLine(salary * 115 / 100);
    }
    else 
    {
        Console.WriteLine(salary);
    }
}
while (true);
