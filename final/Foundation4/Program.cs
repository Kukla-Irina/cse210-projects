using System;

class Program
{
    static void Main(string[] args)
    {

        Running running = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycling = new Cycling("03 Nov 2022", 30, 20.0);
        Swimming swimming = new Swimming("03 Nov 2022", 30, 40);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}