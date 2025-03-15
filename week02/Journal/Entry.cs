public class Entry
{
    public string _date;
    public string _name;
    public string _prompt;
    public string _entry;
    public string _gratitude;

    public void Display()
    {
        Console.WriteLine($"{this._date} {this._name}");
        Console.WriteLine($"{this._prompt}");
        Console.WriteLine($"{this._entry}");
        Console.WriteLine($"{this._gratitude}");
        Console.WriteLine("");
    }
}