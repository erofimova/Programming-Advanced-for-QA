string word = Console.ReadLine();
string sentence = Console.ReadLine();

while (sentence.Contains(word))
{
    int positionWord = sentence.IndexOf(word);
    sentence = sentence.Remove(positionWord, word.Length);

}
Console.WriteLine(sentence);