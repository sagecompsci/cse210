public class Prompts
{
    public List<string> _lists = new List<string>();

    public string Get()
    {
        Random rnd = new Random();
        int index = rnd.Next(_lists.Count);
        return _lists[index];
    }
}