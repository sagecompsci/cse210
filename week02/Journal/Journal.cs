using System.IO;
public class Journal
{
    public List<Entry> _journal = new List<Entry>();

    public void Write_Entry(string prompt, Journal journal)
    {
        Entry entry = new Entry();
        
        DateTime currentDateTime = DateTime.Now;
        entry._date = currentDateTime.ToShortDateString();

        entry._prompt = prompt;

        Console.WriteLine();
        entry._entry = Console.ReadLine();
        
        journal._journal.Add(entry);
    }
    
    public void Display()
    {
        foreach (Entry i in _journal)
        {
            Console.WriteLine(i);
        }
    }

    public void Save(string file)
    {
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry i in _journal)
            {
                outputFile.WriteLine(i);
            }
        }
    }

    public void Load(string file)
    {
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}