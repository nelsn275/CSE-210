using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the lord with all thine heart and understanding; in all thy ways acknowledge him, and he shall direct thy path.");

        while (userInput != "quit")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            scripture.HideRandomWords();
        }
    }
}