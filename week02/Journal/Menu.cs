public class Menu
{
    public List<string> _options = new List<string>();
    int _answer;

    public void Run(string prompt)
    {
        do
        {
            int count = 0;
            foreach (string item in _options)
            {
                count += 1;
                Console.WriteLine($"{count}. {item}");
            }

            Console.Write("What would you like to do? ");
            _answer = int.Parse(Console.ReadLine());

            Journal journal = new Journal();
            if (_answer == 1)
            {
                
                journal.Write_Entry(prompt, journal);
            }

            if (_answer == 2)
            {
                journal.Display();
            }
        } while (_answer != 5);
    }

}