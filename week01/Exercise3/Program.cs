using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        bool play = false;
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess;
            int guessNum = 0;

            do
            {
                Console.Write("Guess a number ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }

                guessNum += 1;

            } while (guess != number);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessNum} tries.");

            Console.Write("Do you want to play again? (yes/no) ");
            string playAgain = Console.ReadLine();
            if (playAgain == "yes")
            {
                play = true;
            }

            if (playAgain == "no")
            {
                play = false;
            }

        } while (play);

    }
}