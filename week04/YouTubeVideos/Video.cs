public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int NumOfComments()
    {
        int num = 0;
        foreach (Comment item in _comments)
        {
            num += 1;
        }

        return num;
    }
    public void Display()
    {
        Console.WriteLine($"{_title} - {_author}");
        Console.WriteLine($"{_length} seconds long");
        Console.WriteLine($"Number of comments: {NumOfComments()}");
        foreach (Comment item in _comments)
        {
            item.Display();
        }
        
        Console.WriteLine("");
    }
}
