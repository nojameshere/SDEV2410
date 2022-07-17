Console.WriteLine("Chaper 6 Miles Per Gallon with Try/Catch by James Sales\n");
bool continueRunning = true;
double miles;
double gallons;
double trips = 0;
double totalMiles = 0;
double totalGallons = 0;

while(continueRunning)
{
    try
    {
        Console.Write("How many miles? ");
        miles = double.Parse(Console.ReadLine());
        Console.Write("How many gallons? ");
        gallons = double.Parse(Console.ReadLine());
        try
        {
            //Checks if gallons is zero, Throws new divide by zero exception.
            if (gallons == 0)
            {
                throw new DivideByZeroException();
            }
            Console.WriteLine($"MPG = {miles / gallons}");
            totalGallons = totalGallons + gallons;
            totalMiles = totalMiles + miles;
            trips++;
        }
        catch (DivideByZeroException)
        {
            //Make sure gallons is not zero
            Console.WriteLine("Cannot divide by zero.");
        }
    }
    catch(FormatException )
    {
        //Make sure inputed data is valid and a double
        Console.WriteLine("Incorrect data format for a double.");
    }
    finally
    {
        //Asks user if they want to input more data
        Console.Write("More data to input? (y/n) ");
        if (Console.ReadLine() == "n") 
        { 
            continueRunning = false; 
        }
    }
}

Console.WriteLine($"\nOverall MPG for {trips} trips = {totalMiles / totalGallons}");

Console.WriteLine("\nPress the any key to continue");
Console.ReadKey();