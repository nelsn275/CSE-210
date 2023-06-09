using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the Grade %: ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letterGrade = "";
        bool pass = false;


        if (gradeInt >= 90)
        {
            letterGrade = "n A";
            pass = true;
        }
        else if (gradeInt >= 80)
        {
            letterGrade = " B";
            pass = true;
        }
        else if (gradeInt >= 70)
        {
            letterGrade = " C";
            pass = true;
        }
        else if (gradeInt >= 60)
        {
            letterGrade = " D";
        }
        else
        {
            letterGrade = " F";
        }

        Console.WriteLine($"Your grad is a{letterGrade}");

        if (pass)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class");
        }


    }
}