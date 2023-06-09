using System;

class Program
{
    static void Main(string[] args)
    {

        displayWelcome();

        string name = promptUserName();
        int number = promptUserNumber();

        int numSquared = squareNumber(number);

        displayResult(numSquared, name);

        static void displayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string promptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            return name;
        }

        static int promptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string num = Console.ReadLine();
            int number = int.Parse(num);

            return number;
        }

        static int squareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void displayResult(int number, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {number} ");
        }

    }
}