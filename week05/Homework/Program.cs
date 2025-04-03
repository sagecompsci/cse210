using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Jack Harkness", "Web Development");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");
        
        MathAssignment mathAssignment = new MathAssignment("John Smith", "Fractions", "4.1", "1-13");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment writingAssignment = new WritingAssignment("Clara Oswald", "Civil War", "Why War Is Bad");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}