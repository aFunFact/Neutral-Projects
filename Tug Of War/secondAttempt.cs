using System.Diagnostics;

string arena = @"
============================================================";
string characters = @"
{}                      {}
||\====================/||
/\                      /\";
string Empty = @"
                           
                           
                           ";


if (OperatingSystem.IsWindows())
{
    Console.WindowWidth = Math.Max(Console.WindowWidth, 50);
    Console.WindowHeight = Math.Max(Console.WindowHeight, 50);
}
Console.SetCursorPosition(0 , 9);
Console.WriteLine(arena);
var (left, top) = Move(1);

while (true)
{
    Console.SetCursorPosition(left, top);
    Render(characters);
    int aD = 0;
    Stopwatch stopwatch = new();
    TimeSpan second = TimeSpan.FromSeconds(1);
    stopwatch.Restart();
    while (stopwatch.Elapsed < second)
    {
        int newLine = 0;
        if (Console.ReadKey().Key == ConsoleKey.A)
        {
            aD++;
        }
    }
    while (true)
    {
        if (aD >= 8)
        {
            Console.SetCursorPosition(left++, top);
            Render(Empty);
            break;
        }
        else
        {
            Console.SetCursorPosition(left--, top);
            Render(Empty);
            break;
        }
    }

}
(int left, int top) Move(int move) =>
    move switch
    {
        1 => (14, 6)
    };

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
        {
            Console.Write(c);
        }
    }
}
