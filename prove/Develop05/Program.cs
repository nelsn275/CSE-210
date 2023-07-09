using System;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {
        List<string> mainMenu = new List<string>()
        {
            "Menu Options:",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit"
        };

        List<string> goalMenu = new List<string>
        {
            "The types of goals are: ",
            "1. Simple Goal",
            "2. Checklist Goal",
            "3. Eternal Goal"
        };

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"You have {points} points");
            foreach (string item in mainMenu){
                Console.WriteLine(item);
            }
            Console.Write("Select a choice from the menu");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    foreach (string option in goalMenu)
                    {
                        Console.WriteLine(option);
                    }
                    Console.WriteLine("What type of Goal would you like to create?");
                    int goalChoice = int.Parse(Console.ReadLine());

                    switch(goalChoice)
                    {
                        case 1:
                            SimpleGoal simplegoal = new SimpleGoal();
                            simplegoal.SetGoalName();
                            simplegoal.SetDescription();
                            simplegoal.SetPoints();
                            simplegoal.AddToList(simplegoal);
                            break;
                        case 2:
                            ChecklistGoal checklistgoal = new ChecklistGoal();
                            checklistgoal.SetGoalName();
                            checklistgoal.SetDescription();
                            checklistgoal.SetPoints();
                            checklistgoal.SetTarget();
                            checklistgoal.SetBonusPoints();
                            checklistgoal.AddToList(checklistgoal);
                            break;
                        case 3:
                            EternalGoal eternalgoal = new EternalGoal();
                            eternalgoal.SetGoalName();
                            eternalgoal.SetDescription();
                            eternalgoal.SetPoints();
                            eternalgoal.AddToList(eternalgoal);
                            break;
                    }
                    break;

                case 2:
                    DisplayGoals();
                    break;

                case 3:
                    Console.Write("What is the filename? ");
                    string fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine();
                    }
                    break;

                case 4:
                    Console.Write("What is the filename?");
                    string filename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");

                        string firstName = parts[0];
                        string lastName = parts[1];
                    }
                    break;

                case 5:
                    RecordEvenet();
                    break;

            }

        }
    }
}