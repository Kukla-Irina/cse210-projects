using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new() {

        new Running(30, 4.8),
        new Cycling(30, 20.0),
        new Swimming(30, 40)

     };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}