// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to character counter!");

string sampleText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

Dictionary<char, int> charCounts = new();

for  (int i = 0; i < sampleText.Length; i++)
{
    if (!charCounts.ContainsKey(sampleText[i]))
    {
        charCounts[sampleText[i]] = 1;
    }
    else
    {
        charCounts[sampleText[i]]++;
    }
}

foreach (KeyValuePair<char, int> pair in charCounts)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}