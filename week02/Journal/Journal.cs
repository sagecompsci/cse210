using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Journal
{
    public List<Entry> _journal;

    public void Write_Entry(string prompt)
    {
        Entry entry = new Entry();
        
        DateTime currentDateTime = DateTime.Now;
        entry._date = currentDateTime.ToShortDateString();

        entry._prompt = prompt;
        Console.WriteLine($"Prompt: {entry._prompt}");
        Console.Write("");
        entry._entry = Console.ReadLine();
        Console.WriteLine("");
        
        this._journal.Add(entry);
    }
    
    public void Display(Journal journal)
    {
        foreach (Entry item in this._journal)
        {
            item.Display();
        }
    }

    public void Save(string file)
    {
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter("journal.txt"))
        {
            foreach (Entry item in this._journal)
            {
                Console.WriteLine("stupid");
                outputFile.WriteLine($"{item._date}~{item._prompt}~{item._entry}");
                outputFile.WriteLine("Hello");
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