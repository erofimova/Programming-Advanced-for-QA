string input = Console.ReadLine();

while (input != "end")
{
    string reversedText = "";
    for (int position = input.Length - 1; position >= 0; position--)
    {
        char curruntSymbol = input[position];
        reversedText += curruntSymbol;
    }
    Console.WriteLine($"{input} = {reversedText}");

    input = Console.ReadLine();
}
