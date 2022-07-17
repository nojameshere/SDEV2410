int userInput = 0, total = 0, count = 0;
double avg = 0;
string answer = "y";
while (answer == "y")
{
    try
    {
        Console.Write("Enter new number: ");
        userInput = Convert.ToInt32(Console.ReadLine());
        total = total + userInput;
        count = count + 1;
    }
    catch (FormatException e)
    {
        Console.WriteLine("Invalid input, please enter an integer");
    }
    Console.Write("Do you have more data to enter? (y/n) ");
    answer = Console.ReadLine();
}
avg = total / count;
Console.WriteLine($"Results: Total = {total}, Count = {count}, Average = {avg}");
