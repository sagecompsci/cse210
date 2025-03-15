using System;
using System.IO;

//I added 2 things to be stored in the entries. When you write an entry it also asks for your 
//name and stores it. After you write your entry, there is another prompt at the end "I am grateful
//for". It also stores what you are grateful for.
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu._options = new List<string>
            { "Write New Entry", "Display Entries", "Save Journal", "Load Journal", "Exit" };
        
        Journal journal = new Journal();
        journal._journal = new List<Entry>();

        Prompts prompts = new Prompts();
        prompts._lists = new List<string>
        {
            "Where do you see yourself in 5 years?",
            "Who is the person you spend the most time with?",
            "If you could relive one year in your life what year would it be?",
            "What skill would you like to learn in the next 5 years?",
            "What was the best thing that happened today?",
            "What was the worst thing that happened today?",
            "What is your favorite mistake that you have made?",
            "What did you do for someone else today?",
            "What did someone else do for you today?"
        };
        
        menu.Display(journal, prompts);
    }
    
}