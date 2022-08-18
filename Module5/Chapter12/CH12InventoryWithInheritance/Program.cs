using System.Collections;
Console.WriteLine("Chapter 12 Inventory with Inheritance by James Sales");

ArrayList items = new ArrayList();
Console.WriteLine("\nEnter inventory for Food and Clothes");
bool cont = true;
do
{
    Console.Write("\nEnter item ID ");
    string ID = Console.ReadLine();
    Console.Write("Enter item name ");
    string itemName = Console.ReadLine();
    Console.Write("What is this item's price? $");
    double price = double.Parse(Console.ReadLine());
    Console.Write("How many are in stock? ");
    int quantity = int.Parse(Console.ReadLine());
    string response;
    bool foodClothingLoop = true;
    do
    {
        Console.Write("Is this a (f)Food item or a (c)Clothing item? ");
        response = Console.ReadLine();
        if (response == "f")
        {
            Console.Write("How many calories? ");
            int calories = int.Parse(Console.ReadLine());
            Console.Write("Does it require refridgeration? (y/n) ");
            string foodResponse = Console.ReadLine();
            string refridgerate;
            if (foodResponse == "y")
            {
                refridgerate = "must refridgerate";
            }
            else
            {
                refridgerate = "refridgeration not needed";
            }
            items.Add(new Food(ID, itemName, price, quantity, calories, refridgerate));
            foodClothingLoop = false;
        }
        else if (response == "c")
        {
            Console.Write("What is the size? (s/m/x/xl) ");
            string size = Console.ReadLine();
            items.Add(new Clothing(ID, itemName, price, quantity, size));
            foodClothingLoop = false;
        }
    }
    while (foodClothingLoop);
    Console.Write("\nDo you have more items to add to inventory? (y/n) ");
    if (Console.ReadLine() == "n")
    {
        cont = false;
    }
}
while (cont);
Console.WriteLine("\nCurrent Inventory");
printInventory();
void printInventory()
{
    foreach (Item item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
cont = true;
while (cont)
{
    Console.Write("\nWhich item do you want to buy? (use ID) ");
    string requsetedItem = Console.ReadLine();
    int index = findItem(items, requsetedItem);
    if (index >= 0)
    {
        Item temp = (Item)items[index];
        temp.Sale();
    }
    else
    {
        Console.WriteLine("That item could not be found in the inventory");
    }
    printInventory();
    Console.Write("\nDo you want to purchase anything else? (y/n)");
    if (Console.ReadLine() == "n")
    {
        cont = false;
    }
}

Console.WriteLine("\nPress something to continue");
Console.ReadKey();




//Helper method for querying the array.
static int findItem(ArrayList items, string itemID)
{
    for (int i = 0; i < items.Count; i++)
    {
        Item item = (Item)items[i];
        if (item.GetID() == itemID)
        {
            Console.WriteLine($"Found item {items[i].ToString()})");
            return i;
        }
    }
    return -1;
}


class Item
{
    public string ID;
    public string name;
    public double price;
    public int quantity;
    public Item(string ID, string name, double price, int quantity)
    {
        this.ID = ID;
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }
    public override string ToString()
    {
        return $"{ID} {name}: quantity {quantity}, price {price:c}";
    }
    public void Purchase()
    {

    }
    public string GetID()
    {
        return this.ID;
    }
    public void Sale()
    {
        Console.Write("How many would you like to buy? ");
        int amountToPurchase = int.Parse(Console.ReadLine());
        if (amountToPurchase <= this.quantity)
        {
            Console.WriteLine($"Cost for this purchse is {amountToPurchase * price:c}");
            quantity -= amountToPurchase;
        }
        else
        {
            Console.WriteLine("There is not enough of this item on hand for quantities requested");
        }
    }
}

class Food : Item
{
    public int caloties;
    public string refridgeration;
    public Food(string ID, string name, double price, int quantity, int calories, string refridgeration)
        : base (ID, name, price, quantity)
    {
        this.caloties = calories;
        this.refridgeration = refridgeration;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, {caloties} calories, {refridgeration} ";
    }
}

class Clothing : Item
{
    public string size;
    public Clothing(string ID, string name, double price, int quantity, string size)
        : base (ID, name, price, quantity)
    {
        this.size = size;
    }
    public override string ToString()
    {
        return $"{base.ToString()}, size {size}";
    }
}