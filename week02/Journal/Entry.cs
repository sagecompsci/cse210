public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public void Display()
    {
        Console.WriteLine($"{this._date} {this._prompt}");
        Console.WriteLine($"{this._entry}");
        Console.WriteLine("");
    }
}