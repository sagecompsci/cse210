using System.IO;

public class Text
{
    private List<string> _text;
    private List<Reference> _reference;
    private int _index;

    public Text(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] data = line.Split(",");
            string book = data[0];
            int chapter = int.Parse(data[1]);
            int startVerse = int.Parse(data[2]);
            int endVerse = int.Parse(data[3]);
            string verse = data[4];

            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            _reference = new List<Reference>();
            _text = new List<string>();
            _reference.Add(reference);
            _text.Add(verse);


        }
    }

    public int GetRandom()
    {
        Random rnd = new Random();
        return rnd.Next(_reference.Count);
    }

    public Reference GetReference(int index = 0)
    {
        return _reference[index];
    }

    public string GetText(int index = 0)
    {
        return _text[index];
    }
}