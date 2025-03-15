public class Menu
{
    public List<string> _options = new List<string>();
    int _answer;

    public void Display(Journal journal, Prompts prompts)
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
            Console.WriteLine("");

            if (_answer == 1)
            {
                 journal.Write_Entry(prompts.Get());
            }

            if (_answer == 2)
            {
                journal.Display(journal);
            }

            if (_answer == 3)
            {
               Console.Write("What file name do you want to save it to? ");
               string file = Console.ReadLine();
               journal.Save(file);
            }
        } while (_answer != 5);
    }

}