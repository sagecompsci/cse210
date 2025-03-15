public class Menu
{
    public List<string> _options = new List<string>();
    
    public void Display(Journal journal, Prompts prompts)
    {
        int answer;
        do
        {
            int count = 0;
            foreach (string item in _options)
            {
                count += 1;
                Console.WriteLine($"{count}. {item}");
            }

            Console.Write("What would you like to do? ");
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (answer == 1)
            {
                 journal.WriteEntry(prompts.Get());
            }

            if (answer == 2)
            {
                journal.Display();
            }

            if (answer == 3)
            {
               Console.Write("What file name do you want to save it to? ");
               string file = Console.ReadLine();
               journal.Save(file);
            }

            if (answer == 4)
            {
                Console.Write("What file name do you want to load? ");
                string file = Console.ReadLine();
                journal.Load(file);
            }
        } while (answer != 5);
    }

}