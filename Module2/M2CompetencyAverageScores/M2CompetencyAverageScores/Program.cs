Console.WriteLine("Module 2 Competency Average Scores by James Sales\n");

double input = 0;
double total = 0;
double count = 0;

Console.WriteLine("Enter any number of scores (enter -1 to quit)");

while (input != -1)
{
    try
    {
        Console.Write("Enter a score from 0 to 100: ");
        input = double.Parse(Console.ReadLine());
        if (input == -1) continue;
        if (input < 0 || input > 100) throw new Exception();
        total = total + input;
        count++;
    }
    catch(FormatException)
    {
        Console.WriteLine("Input string was not in a correct format.");
    }
    catch (Exception)
    {
        Console.WriteLine("That is an invalid score, please try again");
    }
}
if (count != 0)
{
    Console.WriteLine($"The average for {count} scores is {total / count}");
}

Console.WriteLine("\nPress any one key to continue");
Console.ReadKey();