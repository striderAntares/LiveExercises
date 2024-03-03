Random rnd = new Random();
int k = rnd.Next(1, 101);
Console.WriteLine(k);
int i = 0;
int n;
beginning:
Console.WriteLine("Would you like to play a game? You have 10 chances to guess the number i hold");
do
{
    try
    {
        n = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("You have failed to type a number");
        goto beginning;
    }
    i++;
    if (n == k)
    {
        Console.WriteLine("Congratz, you win... voices were right");

    }
    else if (n != k)
    {
        Console.WriteLine("You should try again..");
    }
    if (i == 3)
    {
        Console.WriteLine("Here is a clue: it is between 1 and 100");
    }
}
while (i < 10);
Console.WriteLine("You ran out of chances, voices were wrong this time");