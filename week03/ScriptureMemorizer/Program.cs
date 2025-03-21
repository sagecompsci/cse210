using System;


class Program
{
    static void Main(string[] args)
    {
        Text text = new Text("./../../../scriptures.txt");
        int index = text.GetRandom();
        Scriptures scripture = new Scriptures(text.GetReference(index), text.GetText(index));
        
        scripture.GetDisplayTest();

        string answer;

        do
        {
            Console.Write("Continue(enter) or Quit? ");
            answer = Console.ReadLine().ToLower();
            if (answer == "")
            { 
                scripture.HideRandomWords();
                scripture.GetDisplayTest();
            }
            
            if (scripture.IsCompletelyHidden())
            {
                break;
            }


        } while (answer != "quit");
    }
}