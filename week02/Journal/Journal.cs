using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Journal
{
    public List<Entry> _journal;

    public void WriteEntry(string prompt)
    {
        Entry entry = new Entry();
        
        DateTime currentDateTime = DateTime.Now;
        entry._date = currentDateTime.ToShortDateString();
        
        Console.Write("Name: ");
        entry._name = Console.ReadLine();

        entry._prompt = prompt;
        Console.WriteLine($"Prompt: {entry._prompt}");
        Console.Write("");
        entry._entry = Console.ReadLine();
        
        Console.Write("I am grateful for...  ");
        entry._gratitude = $"I am grateful for {Console.ReadLine()}";
        Console.WriteLine("");
        
        this._journal.Add(entry);
    }
    
    public void Display()
    {
        foreach (Entry item in this._journal)
        {
            item.Display();
        }
    }

    public void Save(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry item in this._journal)
            {
                outputFile.WriteLine($"{item._date}~{item._name}~{item._prompt}~{item._entry}~{item._gratitude}");
            }
        }
    }

    public void Load(string file)
    {
        this._journal.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] data = line.Split("~");
            Console.WriteLine(data);
            Entry entry = new Entry();
            entry._date = data[0];
            entry._name = data[1];
            entry._prompt = data[2];
            entry._entry = data[3];
            entry._gratitude = data[4];
            this._journal.Add(entry);
        }
    }
}