using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when done.");
        int num;
        int sum = 0;
        int average = 0;
        int biggest = 0;
        do
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
            

        } while (num != 0);

        foreach (int item in numbers)
        {
            sum += item;
            average = sum / numbers.Count;
            if (item > biggest)
            {
                biggest = item;
            }
        }
        
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The biggest number is {biggest}");
        
        
    }
}