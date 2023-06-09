using System;

class Program
{
    static void Main(string[] args)
    {
        // Grab a random number between 1 and 100 and assign it the name number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);   

        // Get a guess as input from the user
        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        int guess = int.Parse(guessNumber);

        // Continues having the user guess until they get the number all while giving them hints to help them get closer
        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            Console.Write("What is your guess? ");
            guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);
            
        }
        // Finishing statement
        Console.WriteLine("You guessed it!");
    }
}