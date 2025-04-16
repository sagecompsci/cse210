using System;

class Program
{
    static void Main(string[] args)
    {
        Run run = new Run(50, "15 April 2025", "Running", 5);
        Bike bike = new Bike(60, "23 March 2021", "Biking", 7);
        Swim swim = new Swim(45, "21 December 2024", "Swimming", 16);
        
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(bike.GetSummary());
        Console.WriteLine(swim.GetSummary());

    }
}