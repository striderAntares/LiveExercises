do
{ 
Console.WriteLine("Type Male or Female");
string sex = Console.ReadLine().ToLower().Trim();
int counter = 1;
int total = 0;
int kgMale = 0;
int kgFemale = 0;

    if (sex == "male")
    {
        while (kgMale != 1)
        {
            Console.WriteLine("How much he weighs in kilogramms?(if you want to change sex type 1)");
            kgMale = Convert.ToInt32(Console.ReadLine().ToLower().Trim());
            total = total + kgMale;
            Console.WriteLine(total / counter);
            counter++;
           
        }
    
    }
    else if (sex == "female")
    {
        while (kgFemale != 1)
        {
            Console.WriteLine("How much she weighs in kilogramms?(if you want to change sex type 1)");
            kgFemale = Convert.ToInt32(Console.ReadLine().ToLower().Trim());
            total = total + kgFemale;
            Console.WriteLine(total / counter);
            counter++;
        } 
    }
    else
    {
        Console.WriteLine("You should follow instructions");
    }

}
while (true);