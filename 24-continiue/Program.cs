//Sum all the odd numbers starting from 1 to user entered number.
#region continue
bool result = int.TryParse(Console.ReadLine(), out int n1);
int total = 0;
if(result)
{
    for (int i = 1; i <= n1; i++)
    {
        if (i % 2 == 0)
        {
            continue; //notice if this statement is true it will make it continiue to the loop. it is a specialized goto for loops.
        }
        
        total = total + i;

    }
    Console.WriteLine($" Sums of all the odd numbers from 1 to {n1} = {total}");
}
else
{
    Console.WriteLine("Error");
}

#endregion

#region break and return
int n2 = 0;
if (n2<100)
{
    for (n2 = 24; n2<50; n2++)
    {
        if(n2>25)
        { 
            break; //notice it breaks the loop.
        }
    }
    for (n2 = 49; n2 < 100; n2++)
    {
        if (n2 > 50)
        {
            return; //it returns as void. also it ends all the method. difference between break and return is when you enter break it breaks the scope it is in. however when you return inside a method it kills the entire method.
        }
    }
}

n2 += 5;
Console.WriteLine("Number : " + n2);

#endregion