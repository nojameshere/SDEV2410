Console.WriteLine("Chapter 3 Tip Calculator by James Sales");

Console.Write("\nWhat is the cost of dinner? ");
double cost = double.Parse(Console.ReadLine());
void fifteen(double fifteenCost)
{
    Console.WriteLine($"Tip of 15% = {fifteenCost * .15:C}");
}
double twenty(double cost)
{
    double twentyCalc = cost * .2;
    return twentyCalc;
}
double twentyTwo(double twentyTwoCost) => twentyTwoCost * .22;
//15% - void this must be the first defined and the first called 
//20% - returns decimal
//22% - expression-bodied
fifteen(cost);
Console.WriteLine($"Tip of 20% = {twenty(cost):C}");
Console.WriteLine($"Tip of 22% = {twentyTwo(cost):C}");

Console.Write("\nPress the any key to continue...");
Console.ReadKey();