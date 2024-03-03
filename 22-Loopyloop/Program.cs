int i = 1;
int total = 0;
int counter = 0;
while (i <= 1000)
{
    if (i % 5 == 0 && i % 7 != 0)
    {
        counter++;
        Console.WriteLine(counter + ". = " + i);
        total = total + i;
    }
    i++;
}
Console.WriteLine("Their sum= " + total);