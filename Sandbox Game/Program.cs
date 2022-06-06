if (OperatingSystem.IsWindows())
{
    Console.WindowWidth = Math.Max(Console.WindowWidth, 15);
}
Random Random = new();
const string arena = @"
_____________________________________________________________
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|                                                           |
|___________________________________________________________|";
string character =
 " o  " + "\n" +
@"//\ " + "\n" +
@"\\  " + "\n" +
@"| \ " + "\n";
string Empty =
"     " + "\n" +
"     " + "\n" +
"     " + "\n" +
"     " + "\n";
int x = Console.CursorLeft;
int y = Console.CursorTop;
Console.CursorVisible = false;
while (true)
{
    Console.WriteLine(arena);
    ConsoleKey key = Console.ReadKey(true).Key;
    var (left, top) = Map(key);
    Console.SetCursorPosition(left, top);
    Render(Empty);
    Console.SetCursorPosition(left, 16);
    Render(character);


}

(int left, int top) Map(ConsoleKey key) =>
    key switch
    {
        ConsoleKey.A => (x--, y),
        ConsoleKey.D => (x++, y),
        ConsoleKey.S => (x, ++y),
        ConsoleKey.W => (x, --y),
    };
void Render(string @string)
{
    int x = Console.CursorLeft;
    int y = Console.CursorTop;
    foreach(char c in @string)
    {
        if (c is '\n')
        {
            Console.SetCursorPosition(x, ++y);
        }
        else
        {
            Console.Write(c);
        }
    }
}
