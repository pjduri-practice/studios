// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to character counter!");

string fileText = System.IO.File.ReadAllText(@"c:\Users\pjdur\Desktop\SilasBackground.txt");

Dictionary<char, int> charCounts = new();

for  (int i = 0; i < fileText.Length; i++)
{
    if (!charCounts.ContainsKey(fileText[i]))
    {
        charCounts[fileText[i]] = 1;
    }
    else
    {
        charCounts[fileText[i]]++;
    }
}

foreach (KeyValuePair<char, int> pair in charCounts)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}