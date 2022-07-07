Console.WriteLine("Chapter 5 Average Temperatures by James Sales\n");

double low = 0;
double high = 0;
double average = 0;
string continueRunning = "y";
bool dataCheck = true;

do
{
    low = 0;  //Need to set these for the while structure for data validation.
    high = 0;
    while (dataCheck)
    {
        Console.Write("Enter low temperature: ");
        low = double.Parse(Console.ReadLine());
        if (low > -51)
        {
            dataCheck = false;
        }
    }
    dataCheck = true;
    while (dataCheck)
    {
        Console.Write("Enter high temperature: ");
        high = double.Parse(Console.ReadLine());
        if (high > low && high < 121)
        {
            dataCheck = false;
        }
    }
    average = (low + high) / 2;
    Console.WriteLine($"Average for {low} and {high} is {average}");
    Console.Write("Do you have more temperatures? (y/n) ");
    continueRunning = Console.ReadLine();
}
while (continueRunning != "n"); //Will cause the do to continue running until a user types n

Console.WriteLine("\nPress any key to proceed.");
Console.ReadKey();