Console.WriteLine("Chapter 5 Even or Odd by James Sales\n"); // I just realized you could do \n after to create a new line. Go me...

int num = 0;
int total = 0;
string cont = "n";
int oddTotal = 0;
int evenTotal = 0;
do
{
    Console.Write("Please enter a positive number (0 to stop): ");
    num = int.Parse(Console.ReadLine());
    if (num != 0) //Checks if number is zero or not. quits if it is
    {
        if (num > 0)//Checks if the number is positive. inlcudes it if it is
        {
            total = total + num;
            cont = "";
        }
    }
    else if (total > 0) // runs if the total has been changed at all.
    {
        Console.WriteLine($"The total of those numbers is {total}");
        if (total % 2 == 0) //Checks if total number is even
        {
            Console.WriteLine("That number is even");
            evenTotal++;
        }
        else //If total number is odd it ups the odd total
        {
            Console.WriteLine("That number is odd");
            oddTotal++;
        }
        total = 0; //Sets total to zero in case user wants to run again
        Console.Write("Do you want to continue? (y/n) ");
        cont = Console.ReadLine();
    }

}
while (cont != "n"); // Runs continusly until user types "n" for thhe prompt on line 34
Console.WriteLine($"Number of even totals: {evenTotal}");
Console.WriteLine($"Number of  odd totals: {oddTotal}");

Console.WriteLine("\nPress any key to continue");
Console.ReadKey();