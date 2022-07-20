Console.WriteLine("Chapter 7 Inventory by James Sales");

string name = "";
int ID = 0;
int quantity = 0;
double cost = 0;
//Class for inventory items
//in a FOR loop
//create 3 objects
//user inputs data for each object
for (int i = 0; i < 3; i++)
{
    try
    {
        Console.Write("\nEnter the ID of the item: ");
        ID = int.Parse(Console.ReadLine());
    }
    catch(FormatException)
    {
        ID = 1000;
        Console.WriteLine("Error in item ID, using 1000");
    }
    Console.Write("Enter the name of item: ");
    name = Console.ReadLine();
    try
    {
        Console.Write("Enter quantity in stock: ");
        quantity = int.Parse(Console.ReadLine());
    }
    catch(FormatException)
    {
        quantity = 1;
        Console.WriteLine("Error in item quantity, using 1");
    }
    try
    {
        Console.Write("Enter price of item: ");
        cost = double.Parse(Console.ReadLine());
    }
    catch
    {
        cost = 0.01;
        Console.WriteLine("Error in item cost, using 0.01");
    }
    Inventory item;
    item = new Inventory(name, ID, quantity, cost);
    item.displayItem();
}
//use try/catch for user input
//assign default values when data is invalid

//Have shared variable for total value of all items
//Display value at end of run
Console.WriteLine($"\nTotal value of current inventory: ${Inventory.total:N2}");

Console.WriteLine("\nPress the any key to continue.   .   .");
Console.ReadKey();

class Inventory
{
    string name = "";
    int ID = 0;
    int quantity = 0;
    double cost = 0;
    public static double total;

    public Inventory(string name, int ID, int quantity, double cost)
    {
        this.name = name;
        this.ID = ID;
        this.quantity = quantity;
        this.cost = cost;
        total = total + (cost * quantity);

        //Use expression bodied method to list ID and Name
    }

    public string printName() => $"#{ID} {name}:";

    public void displayItem()
    {
        Console.WriteLine($"\n{printName()} {quantity} at ${cost} each, value ${quantity * cost:N2}");
    }
}