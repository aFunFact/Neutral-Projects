string board = @"
       ╔══════╗       
       ║      ║       
       ╚╗    ╔╝       
╔═══╗   ╚╗  ╔╝   ╔═══╗
║   ╚═══╗╚══╝╔═══╝   ║
║       ║    ║       ║
║   ╔═══╝╔══╗╚═══╗   ║
╚═══╝   ╔╝  ╚╗   ╚═══╝
       ╔╝    ╚╗       
       ║      ║       
       ╚══════╝       ";
string northPiece =
"╔══════╗" + $"\n" +
"║XXXXXX║" + $"\n" +
"╚╗XXXX╔╝" + $"\n" +
" ╚╗XX╔╝ " + $"\n" +
"═╗╚══╝╔═";
string westPiece =
"╔═══╗   ╚" + $"\n" +
"║XXX╚═══╗" + $"\n" +
"║XXXXXXX║" + $"\n" +
"║XXX╔═══╝" + $"\n" +
"╚═══╝   ╔";
string eastPiece =
"╝   ╔═══╗" + $"\n" +
"╔═══╝XXX║" + $"\n" +
"║XXXXXXX║" + $"\n" +
"╚═══╗XXX║" + $"\n" +
"╗   ╚═══╝";
string southPiece =
"═╝╔══╗╚═" + $"\n" +
" ╔╝XX╚╗ " + $"\n" +
"╔╝XXXX╚╗" + $"\n" +
"║XXXXXX║" + $"\n" +
"╚══════╝";
int score = 1;
Random Random = new();
bool incorrectButton = false;
/*
while (!incorrectButton)
{
    Console.Clear();
    Render(board);
    score++;
    for (int i = 0; i < score; i++)
    {
        int randPiece = 1; //Random.Next(0, 5);
        if (randPiece == 1)
        { 
            Console.SetCursorPosition(7, 1);
            Render(northPiece);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Render(board);
            Console.WriteLine(score);
            bool button = false;
            while (!button)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key is ConsoleKey.W)
                {
                    score++;
                    button = true;
                    Thread.Sleep(200);
                    Console.SetCursorPosition(7, 1);
                    Render(northPiece);
                }
                else
                {
                    incorrectButton = true;
                    break;
                }
            }
        }
    }
} 

Console.Clear();
Console.WriteLine($"Game Over. {score} score.");
*/

// how do I store multiple values
while (true) 
{
    int[] array = new int[score];
    Console.Clear();
    Render(board);
    foreach (int i in array)
    {
        int index = Random.Next(1, 5);
        array[i] = index;
        var (left, top) = cursorPosition(index);
        if (array[i] == 1)
        {
            Console.SetCursorPosition(left, top);
            Render(northPiece);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Render(board);
            Console.WriteLine(score);
            bool button = false;
            while (!button)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key is ConsoleKey.W)
                {
                    score++;
                    button = true;
                    Thread.Sleep(200);
                    Console.SetCursorPosition(7, 1);
                    Render(northPiece);
                }
                else
                {
                    incorrectButton = true;
                    break;
                }
            }
        }
        if (array[i] == 2)
        {
            Console.SetCursorPosition(left, top);
            Render(westPiece);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Render(board);
            Console.WriteLine(score);
            bool button = false;
            while (!button)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key is ConsoleKey.A)
                {
                    score++;
                    button = true;
                    Thread.Sleep(200);
                    Console.SetCursorPosition(7, 1);
                    Render(northPiece);
                }
                else
                {
                    incorrectButton = true;
                    break;
                }
            }
        }
        if (array[i] == 3)
        {
            Console.SetCursorPosition(left, top);
            Render(eastPiece);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Render(board);
            Console.WriteLine(score);
            bool button = false;
            while (!button)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key is ConsoleKey.D)
                {
                    score++;
                    button = true;
                    Thread.Sleep(200);
                    Console.SetCursorPosition(7, 1);
                    Render(northPiece);
                }
                else
                {
                    incorrectButton = true;
                    break;
                }
            }
        }
        if (array[i] is 4)
        {
            Console.SetCursorPosition(left, top);
            Render(southPiece);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Render(board);
            Console.WriteLine(score);
            bool button = false;
            while (!button)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key is ConsoleKey.S)
                {
                    score++;
                    button = true;
                    Thread.Sleep(200);
                    Console.SetCursorPosition(7, 1);
                    Render(northPiece);
                }
                else
                {
                    incorrectButton = true;
                    break;
                }
            }
        }
    }
}
(int left, int top) cursorPosition(int a) =>
    a switch
    {
        1 => (7, 1),
        2 => (0, 4),
        3 => (13, 4),
        4 => (7, 7),
    };













/*
bool frame = false;
while (true)
{
    Console.Clear();
Console.WriteLine(board);
Console.SetCursorPosition(7, 1);
    if (frame)
    {
        Render(northPiece);
    }
    Thread.Sleep(500);
    frame = !frame;
}
*/


void Render(string @string)
{
    int x = Console.CursorLeft;
    int y = Console.CursorTop;
    foreach (char c in @string)
    {
        if (c == '\n')
        {
            Console.SetCursorPosition(x, ++y);
        }
        else
            Console.Write(c);
    }
}
