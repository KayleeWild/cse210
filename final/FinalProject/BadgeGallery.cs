class BadgeGallery
{
    // variables:
    // ascii representations of the badge, prolly animals
    private string _dolphin = 
    "            ;'-.\n" + 
    "`;-._        )  '---.._\n" +
    "  >  `-.__.-'          `'.__\n" +
    " /_.-'-._         _,   ^ ---)\n" +
    " `       `'------/_.'----```\n"
    ; 
    // methods:
    public void DisplayEarnedBadges()
    {
        /*make it so there is a list of badges to choose from here and be able to return the string based on the function parameters*/
        Console.WriteLine(_dolphin);
    }
}