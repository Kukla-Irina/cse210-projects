using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {

            Console.WriteLine("\nPlease select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    string currentPrompt = prompt.GetPrompt();
                    Console.WriteLine(currentPrompt);
                    string saved = Console.ReadLine();
                    JournalEntry entry = new JournalEntry();
                    DateTime currentTime = DateTime.Now;
                    string dateText = currentTime.ToShortDateString();
                    entry._date = dateText;
                    entry._prompt = $"Prompt: {currentPrompt}";
                    entry._respond = saved;

                    journal._entries.Add(entry);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.LoadFile();
                    break;
                case "4":
                    journal.SaveFile();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Please choose a number between 1 and 5.");
                    break;

            }



        }
    }
}