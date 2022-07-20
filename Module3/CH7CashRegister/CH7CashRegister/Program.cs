Console.WriteLine("Chapter 7 Cash Register by James Sales");
bool continueRunning = true;
CashRegister register = new CashRegister();
while (continueRunning)
{
    //do the thing.
    register.NewSale();
    register.Change();
    Console.Write("More purchases? (y/n) ");
    if (Console.ReadLine() == "n")
    {
        continueRunning = false;
    }
}
Console.WriteLine($"\nTotal Sales: ${register.total:N2}");
Console.WriteLine("\nPress any key to continue");
Console.ReadKey();
class CashRegister
{
    public double total = 0; //The only variable for this class
    double cost = 0;
    double tender = 0;
    double change = 0;
    public CashRegister() //This is the constructor
    {
        //Stuff to do when constructed
    }

    public void NewSale()
    {
        Console.Write("\nWhat is the cost? $");
        cost = double.Parse(Console.ReadLine());
        Console.Write("How much money from customer? $");
        tender = double.Parse(Console.ReadLine());
        //ask for cost of item
        //ask for money from customer
    }

    public void Change()
    {
        change = tender - cost;
        if (change < 0)
        {
            Console.WriteLine("No sale, you didn't pay enough");
        }
        else
        {
            Console.WriteLine($"The change is ${change:N2}");
            total = total + cost;
        }
        //calculate change and catch error for not enough money
    }
}