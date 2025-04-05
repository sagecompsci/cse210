using System.Runtime.CompilerServices;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Loading(1);
        Console.WriteLine("");
        Console.Write("How long in seconds do you want this session to be? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void EndMessage()
    {
        Console.WriteLine($"Well done!!");
        Loading(2);
        Console.WriteLine($"You have completed {_duration} seconds of {_name} Activity.");
        Loading(2);
        Console.WriteLine("");
    }

    public void Loading(int seconds)
    {
        List<string> symbols = new List<string>()
        {
            "|", "/", "-", "\\"
        };
       for (int i = seconds; i > 0; i--)
       {
           for (int j = 0; j < symbols.Count; j++)
           {
               Console.Write("\b \b");
               Console.Write(symbols[j]);
               Thread.Sleep(1000/symbols.Count);
           }

           if (i == 1)
           {
               Console.Write("\b \b");
           }
       } 
    }

    public void Timer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\b \b"); 
            Console.Write(i);
            Thread.Sleep(1000);

            if (i == 1)
            {
                Console.Write("\b \b");
                Console.WriteLine("");
            }
        }
        
    }
}