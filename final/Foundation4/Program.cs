using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold our exercises
        List<Exercise> exercises = new List<Exercise>();

        // Create new exercises

        Running running = new Running("03 Nov 2022", 30, 3.0 );
        Cycling cycling = new Cycling("04 Nov 2022", 30, 15);
        Swimming swimming = new Swimming("05 Nov 2022", 30, 100);

        // Add each exercise to the list
        exercises.Add(running);
        exercises.Add(cycling);
        exercises.Add(swimming);


        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine();
            exercise.DisplaySummary();
        }

    }
}