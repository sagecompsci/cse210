using System.Diagnostics;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>();
    private List<int> _promptsIndex = new List<int>();

    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having" +
                       " you list as many things as you can in a certain area.";
        _prompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];

        _promptsIndex = [];
    }

    public void Run()
    {
        StartMessage();
        Console.WriteLine("List as many repsonses as you can to the following prompt: ");
        Console.WriteLine($"- - - {GetPrompt()}");
        Console.Write("You may begin in: ");
        Timer(5);
        Stopwatch sw = new Stopwatch();
        sw.Start();
        int count = 0;
        do
        {
            Console.Write("");
            Console.ReadLine();
            count += 1;

        } while ( sw.Elapsed.TotalSeconds < _duration);
        
        sw.Stop();
        
        Console.WriteLine("");
        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine("");
        EndMessage();
    }
    
    public string GetPrompt()
    {
        if (_promptsIndex.Count == 0)
        {
            for (int i = 0; i < _prompts.Count; i++)
            {
                _promptsIndex.Add(i);
            }
        }
        Random rnd = new Random();
        int index = rnd.Next(_promptsIndex.Count);
        string prompt = _prompts[index];
        _promptsIndex.RemoveAt(index);
        return prompt;
    }
}