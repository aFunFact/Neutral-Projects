// Reaction Time Test
using System.Diagnostics;
Random Random = new();

const string wait = @"
...";
const string press = @"
PRESS!";
const string late = @"
Too late!";

Console.CursorVisible = false;
TimeSpan? timeSpan = TimeSpan.FromMilliseconds(Random.Next(5000, 6000));
TimeSpan reactionTime = default;
Stopwatch stopwatch = new();
stopwatch.Restart();
Console.WriteLine(wait);
while ( stopwatch.Elapsed < timeSpan )
{
    Console.WriteLine(press); // Having trouble making 'wait' variable wait. 
    if (Console.KeyAvailable && Console.ReadKey().Key is ConsoleKey)
    {
        Console.Clear();
        Console.WriteLine(stopwatch.Elapsed.Milliseconds + "ms");
        break;
    }
}
if ( stopwatch.Elapsed > timeSpan )
{
    Console.Clear();
    Console.WriteLine(late);
}
Loop:
switch (Console.ReadKey(true).Key)
{
    case ConsoleKey.Enter: break;
    case ConsoleKey.Escape: return;
    default: goto Loop;
}
// want to format better and make code cleaner.. add better context for code.
