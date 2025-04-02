using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Vancouver", "BC", "Canada");

        Lecture lecture = new Lecture("C# Programming", "Learn C# from scratch", "2023-10-15", "10:00 AM", address1, "Irina Evsikova", 100);
        Reception reception = new Reception("Networking Event", "Meet industry professionals", "2023-10-20", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "Enjoy a day outdoors", "2023-10-25", "12:00 PM", address3, "Sunny with a chance of rain");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lecture Event");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Standard details:");
        Console.ResetColor();
        Console.WriteLine(lecture.GetStandardDetails());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Full details:");
        Console.ResetColor();
        Console.WriteLine(lecture.GetFullDetails());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Short details:");
        Console.ResetColor();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Reception Event");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Standard details:");
        Console.ResetColor();
        Console.WriteLine(reception.GetStandardDetails());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Full details:");
        Console.ResetColor();
        Console.WriteLine(reception.GetFullDetails());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Short details:");
        Console.ResetColor();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Outdoor Gathering Event");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Standard details:");
        Console.ResetColor();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Full details:");
        Console.ResetColor();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Short details:");
        Console.ResetColor();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}