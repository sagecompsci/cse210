using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Kitten Meowing", "Jane Doe", 116);
        video1.AddComment("Anonymous Camel", "That is the cutest cat ever!");
        video1.AddComment("Anonymous Bat", "lol");
        video1.AddComment("Anonymous Tiger", "My cat does that too.");
        
        videos.Add(video1);

        Video video2 = new Video("Minecraft Landscaping Tips", "Tim Cognito", 1352);
        video2.AddComment("Anonymous Cat", "That looks amazing!");
        video2.AddComment("Anonymous Dog", "Very helpful. Thanks for the tip!");
        video2.AddComment("Anonymous Hyena", "This made my builds look so much better.");
        
        videos.Add(video2);

        Video video3 = new Video("How To Build A Shiplap Fireplace", "Hugh Man", 604);
        video3.AddComment("Anonymous Gecko", "How do you make that look so easy?");
        video3.AddComment("Anonymous Parrot", "You guys are incredibl.");
        video3.AddComment("Anonymous Moose", "I want that fireplace in my house!");
        
        videos.Add(video3);

        foreach (Video item in videos)
        {
            item.Display();
        }
    }
}