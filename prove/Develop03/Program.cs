using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture object with a reference and text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Loop until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear(); // Clear the console
            Console.WriteLine(scripture.GetRenderedText()); // Display the scripture
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break; // Exit the program if the user types 'quit'
            }

            scripture.HideWords(3); // Hide 3 random words
        }

        // Final display when all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine("All words are hidden. Great job memorizing!");
        }
    }


}