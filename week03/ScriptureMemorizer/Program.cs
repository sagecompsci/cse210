using System;

// I added a text file that contains multiple scriptures. The text file is read to separate lists
// for references and scriptures. Then a random index from the list is chosen and displays the 
// correct reference and scripture. I also made it so that if a word is already hidden, it chooses
// another word to hide.
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