using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an address for each event
        Address addy1 = new Address("123 N Peach Blvd", "Rollins", "North Carolina", "USA");
        Address addy2 = new Address("456 S Jamison St", "Los Angeles", "California", "USA");
        Address addy3 = new Address("789 Couch Ct", "Tamba Bay", "Florida", "USA");

        // Create new events
        Lecture lecture = new Lecture("Face to Face with Neil L. Anderson", "Come ask an apostle questions in person!", "03/24/2024", "4:00 PM", "Lecture", "Neil L. Anderson", 150);
        Reception reception = new Reception("John and Jane Wedding", "Come celebrate a wonderful union of 2 amazing people", "05/06/25", "5:00 PM", "Reception", "john&janewedding@gmail.com" );
        OutdoorGathering outdoorGathering = new OutdoorGathering("Journey Live Performance", "This saturday Journey will be performing live at Wilkshan Park", "07/22/23", "7PM", "Outdoor Gathering", "Partly Cloudy");

        // Give each event an address
        lecture.SetAddress(addy1);
        reception.SetAddress(addy2);
        outdoorGathering.SetAddress(addy3);

        // For each event, display the event info in all 3 methods
        Console.WriteLine("Lecture Information");
        Console.WriteLine();
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullDetails();
        Console.WriteLine();

        Console.WriteLine("Reception Information");
        Console.WriteLine();
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Information");
        Console.WriteLine();
        outdoorGathering.DisplayShortDescription();
        Console.WriteLine();
        outdoorGathering.DisplayStandardDetails();
        Console.WriteLine();
        outdoorGathering.DisplayFullDetails();
        Console.WriteLine();
    }
}