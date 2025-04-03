using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Tutorial", "Irina Evsikova", 600);
        Comment comment1 = (new Comment("Irina", "Great tutorial!"));
        Comment comment2 = (new Comment("Maxim", "Very helpful, thanks!"));
        Comment comment3 = (new Comment("Marina", "I learned a lot."));
        Console.WriteLine();

        Video video2 = new Video("ASP.NET Basics", "Ivan Petrov", 1200);
        Comment comment21 = (new Comment("Maria", "Clear explanations."));
        Comment comment22 = (new Comment("Olga", "Loved the examples."));


        Video video3 = new Video("Advanced C#", "Peter Ivanov", 1800);
        Comment comment31 = (new Comment("Alex", "Advanced concepts explained well."));
        Comment comment32 = (new Comment("Ivan", "Could use more examples."));

        video1.Display();
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (Comment comment in video1.GetComments())
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine($"Number of comments: {video1.GetCommentCount()}");
        Console.WriteLine(); 

        video2.Display();
        video2.AddComment(comment21);
        video2.AddComment(comment22);
        
        Console.WriteLine(); 
        Console.WriteLine("Comments:");
        foreach (Comment comment in video2.GetComments())
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine($"Number of comments: {video2.GetCommentCount()}");
        Console.WriteLine(); 
      
        video3.Display();
        video3.AddComment(comment31);
        video3.AddComment(comment32);

        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (Comment comment in video3.GetComments())
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine($"Number of comments: {video3.GetCommentCount()}");
        Console.WriteLine(); 
    }

}