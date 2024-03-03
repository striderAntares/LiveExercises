do
{ 
try 
{
Console.WriteLine("Enter a number, learn its factorial");    
long i = Convert.ToInt64(Console.ReadLine());
long j = 1;
    if( i == 0)
        Console.WriteLine("Factorial= " + 1);
    else if (i>0 && i<20)
    { 
        do
        {
            j = i * j;
            i--;
        }
        while (i>1);
        Console.WriteLine("Factorial= " + j);
    }
    else 
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