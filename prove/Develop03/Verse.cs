class Verse
{
    /* variables: */
    private List<Word> _wordList = new();
    /* constructors: */
    public Verse(string scriptureText)
    {
        string[] list = scriptureText.Split(' ');
        foreach (string word in list)
        {
            Word _newWord = new(word);
            _wordList.Add(_newWord);
        }
    }
    /* methods: */
    public void Display(int verseNumber)
    {
        Console.Write($"\n{verseNumber}  ");
        foreach (Word lilGuy in _wordList)
        {
            string lilWord = lilGuy.GetWordText();
            Console.Write($"{lilWord} ");
        }
    }
    public int GetWordCount()
    {
        int wordCount = _wordList.Count;
        return wordCount;
    }
    public int GetRevealedCount()
    {
        List<string> revealedList = [];
        foreach (Word lilGuy in _wordList)
        {
            string lilWord = lilGuy.GetWordText();
            string first = lilWord.Substring(0,1);
            if (first != "_")
            {
                revealedList.Add(lilWord);
            }
        }
        int revealedCount = revealedList.Count;
        return revealedCount;
    }
    public void HideWord()
    {
        // Random rnd = new();
        int index = GetRandomNumber();
        // int count = GetWordCount();
        // List<int> randyList = [];
        // for (int i = 0; i <= (count - 1); i++)
        // {
        //     randyList.Add(i);
        // }
        // int randyIndex = rnd.Next(0, randyList.Count() - 1);
        // randyList.Remove(randyIndex);
        Word hideNSeek = _wordList[index];
        bool isItShowing = hideNSeek.IsShowing();
        while (isItShowing == false)
        {
            index = GetRandomNumber();
            hideNSeek = _wordList[index];
            isItShowing = hideNSeek.IsShowing();
        }
        // Word hideNSeek = _wordList[index];
        hideNSeek.Hide();
    }
    public int GetRandomNumber()
    {
        Random rando = new();
        int randomIndex = rando.Next(0, GetWordCount());
        return randomIndex;
    }
}