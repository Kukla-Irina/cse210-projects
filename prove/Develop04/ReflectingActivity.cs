public class ReflectingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    private List<string> _usedQuestions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("Get ready...");
        ShowCountDown(5);
        Console.Clear();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(" ");
        Console.WriteLine($"  --- {GetRandomPrompt()} ---  ");
        Console.WriteLine(" ");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine(" ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        do
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
        } while (DateTime.Now < stopTime);

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int prompt = randomGenerator.Next(0, _prompts.Count);
        return _prompts[prompt];
    }

    public string GetRandomQuestion()
    {
        if (_usedQuestions.Count >= _questions.Count)
        {
            Console.WriteLine(" ");
            Console.Write("No more questions. You might want to think about the following again.");
            Console.WriteLine(" ");
            _usedQuestions.Clear();
        }

        Random randomGenerator = new Random();
        int questionIndex;
        string selectedQuestion;

        do
        {
            questionIndex = randomGenerator.Next(0, _questions.Count);
            selectedQuestion = _questions[questionIndex];
        } while (_usedQuestions.Contains(selectedQuestion));

        _usedQuestions.Add(selectedQuestion);

        return selectedQuestion;
    }
}