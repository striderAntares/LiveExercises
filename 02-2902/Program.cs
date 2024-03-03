//casting nedir? casting büyük bir nesneyi küçüğe atarken ne olduğunu belirtmemizdir. unboxing sürecinde kullanılır çünkü mesela object yapıyı inte atarken object intten büyük olduğundan casting etmek gerekir. object her şeyi kapsar. boxing sürecinde küçük bir şeyi büyük bir şeye attığımız için sıkıntı değil. castinge gerek yok. integerı objecte kolay atarsın.

//faktöriyel

using System.Runtime;

Console.WriteLine("You should enter a number if you wish to see it's factorial");
int n = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
int counter = 1;

control:
if (n == 0)
{
    factorial = 1;
}
else if (n<0)
{ 
    goto negativeN;
}
Console.WriteLine("Entered number= " + n + " Factorial= " + factorial);
if(n>counter)
{
    counter++;
    factorial = factorial * counter;
    goto control;
}
negativeN:
Console.WriteLine("You really shouldn't enter a negative number");