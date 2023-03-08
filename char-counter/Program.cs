// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to character counter!");
Console.WriteLine("Enter some text and we'll count the letters: ");

string inputText = Console.ReadLine();

Dictionary<char, int> charCounts = new();

for  (int i = 0; i < inputText.Length; i++)
{
    if (!charCounts.ContainsKey(inputText[i]))
    {
        charCounts[inputText[i]] = 1;
    }
    else
    {
        charCounts[inputText[i]]++;
    }
}

foreach (KeyValuePair<char, int> pair in charCounts)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}