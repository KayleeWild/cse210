class BadgeGallery
{
    // variables:
    // ascii representations of the badge, credit to https://www.asciiart.eu
   private string _elephant = 
   @"
                            ____
                       .---'-    \
          .-----------/           \
         /           (         ^  |   __
    &   (             \        O  /  / .'
    '._/(              '-'  (.   (_.' /
         \                    \     ./
          |    |       |    |/ '._.'
          )   @).____\|  @ |
      .  /    /       (    | 
     \|, '_:::\  . ..  '_:::\ ..\).
   ";
   private string _turtle = 
    @"
      _____     ____
     /      \  |  o | 
    |        |/ ___\| 
    |_________/     
    |_|_| |_|_|
    ";
    private string _dolphin = 
    @"
                ;'-. 
    `;-._        )  '---.._
      >  `-.__.-'          `'.__
     /_.-'-._         _,   ^ ---)
     `       `'------/_.'----```
                     `
    "; 
    private string _bear = 
    @"
     __         __
    /  \.-***-./  \
    \    -   -    /
     |   o   o   |
     \  .-'''-.  /
      '-\__Y__/-'
         `---`
    ";
    private string _eagle = 
    @"
              __
             /'{>
         ____) (____
       //'--;   ;--'\\
      ///////\_/\\\\\\\
             m m
    ";
    private string _camel = 
    @"
       //
     _oo\
    (__/ \  _  _
       \  \/ \/ \ 
       (         )\
        \_______/  \
         [[] [[]
         [[] [[]
    ";
    private string _owl =
    @"
         __________
        / ___  ___ \
       / / @ \/ @ \ \
       \ \___/\___/ /\
        \____\/____/||
        /     /\\\\\//
       |     |\\\\\\
        \      \\\\\\
         \______/\\\\
            _||_||_
    ";
    private string _yak = 
    @"
    ((_,...,_))    
       |o o|
       \   /
        ^_^  
    ";
    private string _lion = 
    @"
            @|\@@
           -  @@@@
          /7   @@@@
         /    @@@@@@
         \-' @@@@@@@@`-_______________
          -@@@@@@@@@             /    \
     _______/    /_       ______/      |__________-
    /,__________/  `-.___/,_____________----------_)
    ";
    private string _cow = 
    @"
    \|/          (__)    
         `\------(oo)
           ||    (__)
           ||w--||     \|/
       \|/
    ";
    private string _dog = 
    @"
      _   _
     /(. .)\    )
       (*)____/|
       /       |
      /   |--\ |
     (_)(_)  (_)
    ";
    private string _whale = 
    @"
           .
          ~:~
        ___:____     |`\/`|
      ,'        `.    \  /
      |  O        \___/  |
    ~^~^~^~^~^~^~^~^~^~^~^~^~
    ";
    private string _snail = 
    @"
    @             _________
     \____       /         \
     /    \     /   ____    \
     \_    \   /   /    \    \
       \    \ (    \__/  )    )
        \    \_\ \______/    /
         \      \           /___
          \______\_________/____'-_
    ";
    private string _pig = 
    @"
        _____  
    ^..^     \9
    (oo)_____/ 
       WW  WW
    ";
    private string _moose = 
    @"
     ___            ___
    /   \          /   \
    \_   \        /  __/
     _\   \      /  /__
     \___  \____/   __/
        \_       _/
          | @ @  \_
          |
        _/     /\
       /o)  (o/\ \_
       \_____/ /
         \____/
    ";
    private string _rabbit = 
    @"
             ,\
             \\\,_
              \` ,\
         __,.-` =__)
       .`        )
    ,_/   ,    \/\_
    \_|    )_-\ \_-`
       `-----` `--`
    ";
    private string _alligator = 
    @"
               .-._   _ _ _ _ _ _ _ _
    .-''-.__.-'00  '-' ' ' ' ' ' ' ' '-.
    '.___ '    .   .--_'-' '-' '-' _'-' '._
     V: V 'vv-'   '_   '.       .'  _..' '.'.
       '=.____.=_.--'   :_.__.__:_   '.   : :
              (((____.-'        '-.  /   : :
                                (((-'\ .' /
                              _____..'  .'
                            '-._____.-'
    ";
    private string _snake = 
    @"
                 ____
                / . .\
                \  ---<
                 \  /
       __________/ /
    -=:___________/
    ";
    private string _mouse = 
    @"
     _    _
    (o)__(o)   
     \ .. /  
     ==\/==   
     (m  m)  
    m(____)m
    ";
    private string _rhino = 
    @"
                  _                 __                 
          __.--**` `**--...__..--**`  `*-.            
        .'                                `-.         
      .'                         _           \        
    /                         .'        .    \   _._ 
    :                         :          :`*.  :-'.' ;
    ;    `                    ;          `.) \   /.-' 
    :     `                             ; ' -*   ;    
          :.    \           :       :  :        :    
     ;     ; `.   `.         ;     ` |  '             
     |         `.            `. -*`*\; /        :     
     |    :     /`-.           `.    \/`.'  _    `.   
     :    ;    :    `*-.__.-*```:`.   \ ;  'o` `. /   
          ;   ;                ;  \   ;:       ;:   ,/
      |  | |                       /`  | ,      `*-*'/ 
      `  : :  :                /  /    | : .    ._.-'  
       \  \ ,  \              :   `.   :  \ \   .'     
        :  *:   ;             :    |`*-'   `*+-*       
        `**-*```               *---*
    ";
    // methods:
    public string[] GetBadgesList()
    {
        // I need 14 badges
        /*make it so there is a list of badges to choose from here and be able to return the string based on the function parameters*/
        return [_elephant, _turtle, _dolphin, _bear, _eagle,
                 _camel, _owl, _yak, _lion, _cow,
                 _dog, _whale, _snail, _pig, _moose,
                 _rabbit, _alligator, _snake, _mouse, _rhino];
    }
}