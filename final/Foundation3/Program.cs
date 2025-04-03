using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new("123 Main St", "Springfield", "IL", "USA");
        Lecture lecture = new("Lecture", "C# Programming", "Learn C# from scratch", "2025-10-15", "10:00 AM", address1, "Irina Evsikova", 100);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lecture Event");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Standard details:");
        Console.ResetColor();
        lecture.GetStandardDetails();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Full details:");
        Console.ResetColor();
        lecture.GetFullDetails();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Short details:");
        Console.ResetColor();
        lecture.GetShortDescription();
        Console.WriteLine();

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Reception reception = new Reception("Reception", "Networking Event", "Meet industry professionals", "2025-10-20", "6:00 PM", address2, "rsvp@example.com");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Reception Event");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Standard details:");
        Console.ResetColor();
        reception.GetStandardDetails();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Full details:");
        Console.ResetColor();
        reception.GetFullDetails();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Short details:");
        Console.ResetColor();
        reception.GetShortDescription();
        Console.WriteLine();

        Address address3 = new Address("789 Oak St", "Vancouver", "BC", "Canada");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering", "Picnic", "Enjoy a day outdoors", "2025-10-25", "12:00 PM", address3, "Sunny with a chance of rain");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Outdoor Gathering Event");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Standard details:");
        Console.ResetColor();
        outdoorGathering.GetStandardDetails();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Full details:");
        Console.ResetColor();
        outdoorGathering.GetFullDetails();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Short details:");
        Console.ResetColor();
        outdoorGathering.GetShortDescription();
    }
}