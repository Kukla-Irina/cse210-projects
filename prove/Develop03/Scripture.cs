class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor to initialize the scripture
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Hides a specified number of random words (only if they are not already hidden)
    public void HideWords(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.FindAll(word => !word.IsHidden()); // Get all visible words

        // Ensure we don't try to hide more words than are visible
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count); // Randomly select a visible word
            visibleWords[index].Hide(); // Hide the word
            visibleWords.RemoveAt(index); // Remove it from the visible words list
        }
    }

    // Returns the rendered text with hidden words replaced by underscores
    public string GetRenderedText()
    {
        string renderedText = _reference.GetReference() + "\n";
        foreach (Word word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText.Trim();
    }

    // Checks if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}