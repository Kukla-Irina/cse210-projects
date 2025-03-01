using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
       
        while (true)
        {

            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.Clear();


            switch (choice)
            {
                case "1":
                   BreathingActivity breathingActivity = new();
                breathingActivity.Run();
                    break;
                case "2":
                     ReflectingActivity reflectingActivity = new();
                reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity =  new();
                listingActivity.Run();
                    break;
                case "4":
                   return;
                default:
                    Console.WriteLine("Please choose a number between 1 and 4.");
                    break;

            }

        }
    }
}