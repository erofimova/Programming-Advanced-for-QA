string[] badWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string word in badWords)
{
    string replacement = new string('*', word.Length);
    text = text.Replace(word, replacement);
}
Console.WriteLine(text);