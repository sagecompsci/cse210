using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f1 = new Fractions();
        Fractions f2 = new Fractions(6);
        Fractions f3 = new Fractions(6, 7);
        
        f1.SetTop(2);
        f1.SetBottom(3);
        f2.SetTop(4);
        f2.SetBottom(5);
        f3.SetTop(6);
        f3.SetBottom(7);
        
        Console.WriteLine($"{f1.GetTop()}/{f1.GetBottom()}");
        Console.WriteLine($"{f2.GetTop()}/{f2.GetBottom()}");
        Console.WriteLine($"{f3.GetTop()}/{f3.GetBottom()}");
        Console.WriteLine("");
        
        Console.WriteLine(f1.GetString());
        Console.WriteLine(f1.GetDecimal());
        Console.WriteLine(f2.GetString());
        Console.WriteLine(f2.GetDecimal());
        Console.WriteLine(f3.GetString());
        Console.WriteLine(f3.GetDecimal());
        
    }
}