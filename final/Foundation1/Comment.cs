class Comment
{
    public string _commenterName;
    public string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public string GetComment()
    {
        return $"{_commenterName}: {_commentText}";
    }
}