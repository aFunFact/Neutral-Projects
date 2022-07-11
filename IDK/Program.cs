string letters = @"v f x t c u";
Random random = new Random();
string[] lArray = letters.Split(' ');
List<string> usedStrings = new List<string>();


for (int i = 0; i < 15; i++)
{
    
    Console.WriteLine();
    int c = 0;
Loop:
    for (int a = 0; a < lArray.Length; a++)
    {
        
        c = random.Next(0, lArray.Length);
        if (usedStrings.Contains(lArray[c]))
        {
            goto Loop;
        }
        usedStrings.Add(lArray[c]);
        Console.Write(lArray[c]);

    }
}
// IDK what im trying to accomplish I just wrote code to do something.
