Console.WriteLine("Chapter 10 Inventory Array by James Sales");

int size = 3;
Item[] items = new Item[size];
//Add items to the array.
for (int i = 0; i < 3; i++)
{
    string itemName;
    int itemID;
    double itemPrice;
    int itemQuantity;
    Console.WriteLine("\nAdd items to inventory");
    Console.Write("Enter name of new item: ");
    itemName = Console.ReadLine();
    Console.Write("Enter ID number of new item: ");
    itemID = int.Parse(Console.ReadLine());
    Console.Write("Enter price of this item: $");
    itemPrice = double.Parse(Console.ReadLine());
    Console.Write("Enter quantity for this item: ");
    itemQuantity = int.Parse(Console.ReadLine());
    //Creates new item with gathered info
    Item temp = new Item(itemName, itemID, itemPrice, itemQuantity);
    //Adds newly created item to the array
    items[i] = temp;
}
bool cont = true;
while (cont)
{
    Console.Write("\nWhat do you want to do: (s)Sell, (r)Restock, (p)Print, (x)Exit? ");
    string selection = Console.ReadLine();
    if (selection == "s" || selection == "r" || selection == "p" || selection == "x")
    {
        int enteredID;
        int index;
        switch (selection)
        {
            case "s":
                //Code for sale
                //Find specifit item and run item.Sale()
                Console.Write("Enter item ID ");
                enteredID = int.Parse(Console.ReadLine());
                index = findItem(items, enteredID);
                if (index == -1)
                {
                    Console.WriteLine("Invalid ID number");
                }
                else
                {
                    Console.WriteLine($"{items[index].Sale()}");
                }
                break;
            case "r":
                //Code for restock
                //Find item and run item.Restock()
                Console.Write("Enter item ID ");
                enteredID = int.Parse(Console.ReadLine());
                index = findItem(items, enteredID);
                if (index == -1)
                {
                    Console.WriteLine("Invalid ID number");
                }
                else
                {
                    Console.WriteLine($"{items[index].Restock()}");
                }
                break;
            case "p":
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine($"{items[i].Display()}");
                }
                //Code for print
                //Needs to item.Display() all items in the array 
                break;
            case "x":
                //code for exit
                cont = false;
                break;
        }
    }
    else { Console.WriteLine("Invalid option, please try again"); }
}
Console.WriteLine("\nPress any key to continue");
Console.ReadKey();

static int findItem(Item[] items, int itemID)
{
    for (int i = 0; i < items.Length; i++)
    {
        if (items[i].GetID() == itemID)
        {
            Console.WriteLine($"Found item {items[i].Display()})");
            return i;
        }
    }
    return -1;
}

class Item
{
    string name;
    int ID;
    double price;
    int quantity;

    public Item(string itemName, int itemID, double itemPrice, int itemQuantity)
    {
        name = itemName;
        ID = itemID;
        price = itemPrice;
        quantity = itemQuantity;
    }
    public string Display()
    {
        return $"{ID} {name}, price {price:C}, {quantity} on hand";
    }
    public int GetID() => ID;
    public string Restock()
    {
        Console.Write("What is the new quantity? ");
        int newQuantity = int.Parse(Console.ReadLine());
        quantity = newQuantity;
        return Display();
    }
    public string Sale()
    {
        Console.Write("How many sold? ");
        int saleQuantity = int.Parse(Console.ReadLine());
        if (saleQuantity <= quantity)
        {
            quantity -= saleQuantity;
            return Display();
        }
        else
        {
            return "Not enough on hand to complete the sale";
        }
    }
}