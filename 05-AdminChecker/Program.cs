string userName = Console.ReadLine();
string password = Console.ReadLine();

do
if (userName == "Admin" || userName == "admin" && password == "1234")
{
    Console.WriteLine("Success");
}
else 
{
    Console.WriteLine("You should try again");
}
while (true);