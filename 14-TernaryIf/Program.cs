int x = Convert.ToInt32(Console.ReadLine());
if (x >= 5)
    Console.WriteLine("Your number is bigger or equal to five");
else
    Console.WriteLine("Your number is smaller than five");

Console.WriteLine(x >= 5 ? "bigger or equal" : "smaller");

int n1 = 1;
int n2 = 10;

Console.WriteLine(n2>n1 ? n2 : (n1==n2) ? "Equals" : n2);

int n3 = Convert.ToInt32(Console.ReadLine());
int n4 = Convert.ToInt32(Console.ReadLine());

bool t;
bool f;

Console.WriteLine(n3 > n4 ? t = true : (n3 == n4) ? "Equals" : f = false);

do
{ 
string txt = Console.ReadLine().ToLower().Trim();
Console.WriteLine(txt == "bilge adam" ? "it's a match" : "it is not a match");
}
while (true);