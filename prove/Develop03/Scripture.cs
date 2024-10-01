public class Scripture

{
    private List<Word> _words;
    public Reference ScriptureReference { get; private set; }

    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            var visibleWords = _words.Where(word => !word.IsHidden).ToList();
            if (visibleWords.Count > 0)
            {
                var wordToHide = visibleWords[random.Next(visibleWords.Count)];
                wordToHide.Hide();
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(ScriptureReference.ToString());
        Console.WriteLine(string.Join(" ", _words.Select(word => word.GetDisplayText())));
    }
}
