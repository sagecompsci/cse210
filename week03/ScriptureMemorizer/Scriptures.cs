

using System.Data;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization.Metadata;

public class Scriptures
{
    private Reference _reference;
    private List<Word> _words;
    private List<string> _shown;


    public Scriptures(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _shown = new List<string>();
        List<string> temp = new List<string>(text.Split(" "));
        foreach (string item in temp)
        {
            Word word = new Word(item);
            _words.Add(word);
            _shown.Add(item);
        }
    }
    
    public void HideRandomWords()
    {
        
        Random rnd = new Random();
        for (int i = 0; i < 3; i++)
        {
            if (IsCompletelyHidden())
            {
                break;
            }
            int num;
            do
            {
                num = rnd.Next(_words.Count);
            } while (_words[num].IsHidden());

            _words[num].Hide();
        }
            
    }
    
    public void GetDisplayTest()
    {
        List<string> text = new List<string>();
        foreach (Word item in _words)
        {
            text.Add(item.GetDisplayText());
        }

        Console.Clear();
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine(String.Join(" ", text));
        
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word item in _words)
        {
            if (item.IsHidden() == false)
            {
                return false;
            }
        }
        
        return true;
    }
}