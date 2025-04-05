public class Breathing : Activity
{
    public Breathing()
    {
        _description = "This activity will help you relax by walking you through breathing in and " +
                       "out slowly. Clear your mind and focus on your breathing. ";
        _name = "Breathing";
    }
    
    public void Run()
    {
        StartMessage();
        
        int time = 0;
        do
        {
            Console.Write("Breathe in... ");
            Timer(5);
            Console.Write("Breathe out... ");
            Timer(5);
            Console.WriteLine("");
            time += 10;
        } while (time < _duration);
        
        EndMessage();
    }
}