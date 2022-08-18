Console.WriteLine("Chapter 11 Count Words by James Sales");

Console.Write("\nEnter a sentence: ");
string sentence = Console.ReadLine();
string[] words = sentence.Split(' ');
Console.WriteLine($"There are {words.Length} in that sentence");
int longest = 0;
string longestWord = "";
foreach (string word in words)
{
    if (word.Length > longest)
    {
        longest = word.Length;
        longestWord = word;
    }
}
Console.WriteLine($"The longest word is {longestWord} which is {longest} characters long");

Console.WriteLine("\nPress any key to continue");
Console.ReadKey();