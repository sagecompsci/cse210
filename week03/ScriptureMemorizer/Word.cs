

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        if (_hidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        if (_hidden)
        {
            List<string> text = new List<string>();
            for (int i = 0; i < _word.Count(); i++)
            {
               text.Add("_"); 
            }

            return String.Join("", text);
        } 
        return _word;
    }
}