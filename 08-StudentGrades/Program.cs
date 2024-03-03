tryAgain:
Console.WriteLine("You should enter your grade");
int studentGrade = Convert.ToInt32(Console.ReadLine());
    if (studentGrade <= 100 && studentGrade >= 90)
    {
    Console.WriteLine("Your grade is A");
    }
    else if (studentGrade < 90 && studentGrade >= 85)
    {
    Console.WriteLine("Your grade is B");
    }
    else if (studentGrade < 85 && studentGrade >= 70)
    {
    Console.WriteLine("Your grade is C");
    }
    else if (studentGrade < 70 && studentGrade >= 65)
    {
    Console.WriteLine("Your grade is D");
    }
    else if (studentGrade <65 && studentGrade >= 60)
    {
    Console.WriteLine("Your grade is E");
    }
    else if (studentGrade < 60 && studentGrade >=0)
    {
    Console.WriteLine("You have failed the class");
    }
    else 
    {
    Console.WriteLine("You have failed the program");
    }
    goto tryAgain;
    