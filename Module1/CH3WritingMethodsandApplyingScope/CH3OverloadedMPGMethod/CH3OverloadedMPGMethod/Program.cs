using static System.Console;
public class aClass
{
    public static void Main()
    {
        WriteLine("Chapter 3 Overloaded MPG Method");
        Write("\nEnter an integer for miles: ");
        int miles = int.Parse(ReadLine());
        Write("Enter an integer for gallons: ");
        int gallons = int.Parse(ReadLine());
        //Calls method for int calculation
        WriteLine($"Integer MPG = {calcMPG(miles, gallons)}");

        Write("\nEnter an double for miles: ");
        double milesDouble = double.Parse(ReadLine());
        Write("Enter an double for gallons: ");
        double gallonsDouble = double.Parse(ReadLine());
        //calls double function for MPG calculation
        WriteLine($"Integer MPG = {calcMPG(milesDouble, gallonsDouble)}");

        Write("\nPress any key you'd like to press to continue.. ...");
        ReadKey();
    }
    static int calcMPG(int miles, int gallons)
    {
        int mpg = miles / gallons;
        return mpg;
    }
    static double calcMPG(double miles, double gallons)
    {
        double mpg = miles / gallons;
        return mpg;
    }
}