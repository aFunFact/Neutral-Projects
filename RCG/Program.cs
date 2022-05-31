while (true)
{
    Console.CursorVisible = false;
    Console.Clear();
    Random rand = new();

    string[] colors = { "Color1", "Color2", "Color3", "Color4", "Color5", "Color6", "Color7", "Color8", "Color9", "Color10" };

    for (int i = 0; i < colors.Length; i++)
    {
        var color = (ConsoleColor)rand.Next(1,16);
        Console.ForegroundColor = color;
        Console.WriteLine(colors[i]);
    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();

    //var esc = (ConsoleColor)
    //Console.WriteLine($"Press [{esc}] to exit.");
    //tried assigning an initialized variable a color.. im lost.

    Console.WriteLine("Press [esc] to exit.");
    Console.WriteLine("Press any other key to loop");

    switch (Console.ReadKey(true).Key)
    {
        default: break;
        case ConsoleKey.Escape: return;
    }
}
