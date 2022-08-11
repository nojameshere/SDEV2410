Console.WriteLine("Chapter 10 Dice Rolls Array with by James Sales\n");

int[] rolls = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
Random rng = new Random();
int diceRolls = 0;
for (int i = 0; i < 100; i++)
{
    try
    {
        int temp = rng.Next(1, 7);
        int temp2 = rng.Next(1, 7);
        rolls[(temp + temp2) - 1]++;
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine($"Index was outside the bounds of the array. Index = {i + 1}");
    }
}
for (int i = 0; i < rolls.Length; i++)
{
    try
    {
        Console.WriteLine($"Number of rolls = {i + 1}: {rolls[i]}");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine($"Index was outside the bounds of the array. Index = {i + 1}");
    }
}
for (int i = 0; i < rolls.Length; i ++)
{
    diceRolls += rolls[i];
}
Console.WriteLine($"Total number of rolls: {diceRolls}");

Console.WriteLine("\nPress a key to continue");
Console.ReadKey();