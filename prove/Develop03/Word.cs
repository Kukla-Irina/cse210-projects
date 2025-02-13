class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor to initialize the word
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Shows the word
    public void Show()
    {
        _isHidden = false;
    }

    // Returns the rendered text (either the word or underscores if hidden)
    public string GetRenderedText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    // Checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
}
