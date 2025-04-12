using System;
// I made it so that when you choose to list goals, if the goal in completed, the text is green
class Program
{
    static void Main(string[] args)
    {
        GoalManager goal = new GoalManager();

        int choice = 0;
        do
        {
            goal.DisplayScore();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Exit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            

            if (choice == 1)
            {
                Console.WriteLine("Types of Goals:");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal"); 
                Console.Write("What type of goal do you want to create? ");
                int type = int.Parse(Console.ReadLine());
                
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                
                Console.Write("What is a short description of your goal? ");
                string description = Console.ReadLine();
                
                Console.Write("How many points is your goal worth? ");
                int points = int.Parse(Console.ReadLine());

                if (type == 1)
                {
                    goal.AddSimpleGoal(name, description, points);
                }

                if (type == 2)
                {
                    goal.AddEternalGoal(name, description, points);
                }

                if (type == 3)
                {
                    Console.Write("How many times do you want to accomplish this goal? ");
                    int target = int.Parse(Console.ReadLine());
                    
                    Console.Write("How many bonus points to you get for accomplishing it " +
                                      $"{target} times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    
                    goal.AddChecklistGoal(name, description, target, points, bonus);
                }
            }

            if (choice == 2)
            {
                goal.ListGoals();
            }

            if (choice == 3)
            {
                Console.Write("What file do you want to save to? ");
                string file = Console.ReadLine();
                goal.SaveGoals(file);
            }

            if (choice == 4)
            {
                Console.Write("What file do you want to load from? ");
                string file = Console.ReadLine();
                goal.LoadGoals(file);
            }

            if (choice == 5)
            {
                goal.RecordEvent();
            }
            
        } while (choice != 6);
    }
}