public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(" "); 
        Console.WriteLine(_description);
        Console.WriteLine(" "); 
        Console.Write("How long, in seconds, would you like for your session?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine(" "); 
        Console.WriteLine("Well done!!");
        ShowSpinner(1);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(1);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < stopTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            if (i <= 9)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            if (i > 9)
            {   
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");
            }
        }
    }

}