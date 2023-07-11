using System;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

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
            Console.WriteLine($"You have {goalManager.GetScore()} points");
            foreach (string item in mainMenu){
                Console.WriteLine(item);
            }
            Console.Write("Select a choice from the menu ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch(choice)
            {
                case 1:
                    foreach (string option in goalMenu)
                    {
                        Console.WriteLine(option);
                    }
                    Console.Write("What type of Goal would you like to create? ");
                    int goalChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch(goalChoice)
                    {
                        case 1:
                            SimpleGoal simplegoal = new SimpleGoal();
                            simplegoal.SetGoalName();
                            simplegoal.SetDescription();
                            simplegoal.SetPoints();
                            goalManager.AddToList(simplegoal.GetStringRepresentation());
                            break;
                        case 2:
                            ChecklistGoal checklistgoal = new ChecklistGoal();
                            checklistgoal.SetGoalName();
                            checklistgoal.SetDescription();
                            checklistgoal.SetPoints();
                            checklistgoal.SetTarget();
                            checklistgoal.SetBonusPoints();
                            goalManager.AddToList(checklistgoal.GetStringRepresentation());
                            break;
                        case 3:
                            EternalGoal eternalgoal = new EternalGoal();
                            eternalgoal.SetGoalName();
                            eternalgoal.SetDescription();
                            eternalgoal.SetPoints();
                            goalManager.AddToList(eternalgoal.GetStringRepresentation());
                            break;
                    }
                    break;

                case 2:
                    goalManager.DisplayGoals();
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
                    goalManager.DisplayGoals();
                    break;

            }

        }
    }
}