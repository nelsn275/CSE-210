using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new empty list
        List<int> numbers = new List<int>();

        // Get input from the user
        Console.Write("Enter Number: ");
        string number = Console.ReadLine();
        int newNumber = int.Parse(number);
        int total = 0;

        // Continue getting numbers from the user until they type 0. Add each new number to the total
        while(newNumber != 0)
        {
            Console.Write("Enter Number: ");
            number = Console.ReadLine();
            newNumber = int.Parse(number);

            numbers.Add(newNumber);
            total += newNumber;
        }

        // Display the numbers in the list, the total of the numbers, and the average. Also show the largest number in the list
        Console.WriteLine("The numbers in your list are: ");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {total / numbers.Count}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
        


    }
}