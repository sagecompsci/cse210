using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        int choice = 0;
        do
        {
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
     
            if (choice == 1)
            {
                 breathing.Run();
            }
     
            else if (choice == 2)
            {
                reflection.Run();
            }
            else if (choice == 3)
            {
                listing.Run();
            }
            
        } while (choice != 4);
        
    }
}