using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Tutorial", "Irina Evsikova", 600);
        Video video2 = new Video("ASP.NET Basics", "Ivan Petrov", 1200);
        Video video3 = new Video("Advanced C#", "Peter Ivanov", 1800);

        video1.AddComment(new Comment("Irina", "Great tutorial!"));
        video1.AddComment(new Comment("Maxim", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Marina", "I learned a lot."));

        video2.AddComment(new Comment("Maria", "Clear explanations."));
        video2.AddComment(new Comment("Olga", "Loved the examples."));

        video3.AddComment(new Comment("Alex", "Advanced concepts explained well."));
        video3.AddComment(new Comment("Ivan", "Could use more examples."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}