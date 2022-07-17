Console.WriteLine("Chapter 5 Average Temperatures by James Sales\n");

double low = -1000;
double high = -1000;
double average = 0;
bool continueRunning = true;

do
{
    high = -1000;
    low = -1000;
    do
    {
        Console.Write("Enter low temperature: ");
        low = double.Parse(Console.ReadLine());

    } while (low < -50);
    do
    {
        Console.Write("Enter high temperature: ");
        high = double.Parse(Console.ReadLine());
    } while (high < low || high > 120) ; //this needs to be an or because if either are correct the loop will stop and we want to test for both.

    average = (low + high) / 2;
    Console.WriteLine($"Average for {low} and {high} is {average}");
    Console.Write("Do you have more temperatures? (y/n) ");
    if (Console.ReadLine() == "n")
    {
        continueRunning = false;
    }
}
while (continueRunning); //Will cause the do to continue running until a user types n

Console.WriteLine("\nPress any key to proceed.");
Console.ReadKey();