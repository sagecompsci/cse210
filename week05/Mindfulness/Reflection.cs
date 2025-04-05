public class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<int> _promptsIndex = new List<int>();
    private List<int> _questionsIndex = new List<int>();

    public Reflection()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have " +
                       "shown strength and resilience. This will help you recognize the power " +
                       "you have and how you can use it in other aspects of your life.";
        _prompts =
        [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];

        _questions =
        [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];

        _promptsIndex = [];
        _questionsIndex = [];
    }
    

    public void Run()
    {
        StartMessage();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($" - - - {GetPrompt()}");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Ponder on each of the following questions as they relate to this experience. ");
        Console.WriteLine("");

        int time = 0;
        do
        {
            Console.WriteLine(GetQuestion());
            Loading(5);
            time += 5;
        } while(time < _duration);
        
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
        string prompt = _prompts[_promptsIndex[index]];
        _promptsIndex.RemoveAt(index);
        return prompt;
    }

    public string GetQuestion()
    {
        int time = 0;
        do
        {
            if (_questionsIndex.Count == 0)
            {
                for (int i = 0; i < _questions.Count; i++)
                {
                    _questionsIndex.Add(i);
                }
            }
            Random rnd = new Random();
            int index = rnd.Next(_questionsIndex.Count);
            string question = _questions[_questionsIndex[index]];
            _questionsIndex.RemoveAt(index);
            return question;
        } while (time < _duration);
    }
}