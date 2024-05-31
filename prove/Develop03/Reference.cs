class Reference
{
    /* variables: */
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    /* constructors: */
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    /* methods: */
    public void Display()
    {
        if (_endVerse == _startVerse)
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
        }
        else if (_endVerse > _startVerse)
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
        else 
        {   
            string error = "Error: end verse is smaller than start verse";
            Console.WriteLine(error);
        }
    }
}