using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal         journal = new Journal();
        Console.WriteLine("\nWelcome to the Journal Program!");

        int choice = chooseOption();

        while (choice != 5)
        {
            if (choice == 1)
            {
                
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.Date.ToString("mm dd, yyyy");

                Entry entry= new Entry(date, prompt, response);
                journal.AddEntry(entry);
                choice = chooseOption();

            }
            else if (choice == 2)
            {
                journal.DisplayAll();
                choice = chooseOption();

            }
            else if (choice == 3)
            {
                Console.WriteLine("Name of file to load");
                string fileNameLoad = Console.ReadLine();
                journal.LoadFromFile(fileNameLoad);
                choice = chooseOption();

            }
            else if (choice == 4)
            {
                Console.WriteLine("Name of file to save");
                string fileNameSave = Console.ReadLine();
                journal.SaveToFile(fileNameSave);
                choice = chooseOption();
            }
        }
    }
    
    // When called, this function will display the options and receive an input of what the user wants to have done
    static int chooseOption()
    {
        Console.WriteLine("Please Choose One of the Following Choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        int choiceInt = int.Parse(Console.ReadLine());

        return choiceInt;
    }
}