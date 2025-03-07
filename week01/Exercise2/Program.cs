using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "";
        bool pass = false;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }    
        else if (grade >= 70)
        {
            letter = "C";
        }    
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            pass = true;
        }    
        
        Console.WriteLine($"You got a {letter}!!");
        if (pass)
        {
            Console.WriteLine("Congratulations! You passes the class!!");
        }
        else
        {
            Console.WriteLine("You failed the class. Better luck next time.");
        }
    }
}