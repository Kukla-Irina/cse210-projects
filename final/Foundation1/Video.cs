class Video
{
    public string _title;
    public string _author;
    public int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
        this._comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in _comments)
            {
                Console.WriteLine($" - {comment._commenterName}: {comment._commentText}");
            }
            Console.WriteLine();
    }
}
