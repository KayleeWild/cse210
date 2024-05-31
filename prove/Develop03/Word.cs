class Word 
{
    /* variables: */
    private string _wordText;
    private bool _isShowing = true;
    /* constructors: */
    public Word(string word)
    {
        _wordText = word;
        _isShowing = true;
    }
    /* methods: */
    public void Hide()
    {
        int length = _wordText.Length;
        string hidden = new string('_', length);
        _wordText = hidden;
        _isShowing = false;
    }
    public bool IsShowing()
    {
        return _isShowing;
    }
    public string GetWordText()
    {
        return _wordText;
    }
}