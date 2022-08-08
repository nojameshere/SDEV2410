Console.WriteLine("Module 3 Competency Assignment Purchases by James Sales\n");

Item cicada = new Item("3301", "Cicada", 33.01, 3301);
Item techDeck = new Item("422", "Tech Deck", 1.93, 419);

Customer todd = new Customer("Todd", "Lasseu", "2");
Customer clint = new Customer("Clint", "Betts", ">6500");

Employee tim = new Employee("Tim", "Apple", "004");
Employee ajit = new Employee("Ajit", "Pai", "I hate this guy");

Console.WriteLine(cicada.ToString());
Console.WriteLine(techDeck.ToString());

Object theBox;
for(int i = 0; i < 4; i++)
{
    if (i == 0) {theBox = todd;}
    else if (i == 1) { theBox = clint; }
    else if (i == 2) { theBox = tim; }
    else { theBox = ajit; }

    Console.WriteLine($"\nProcessing purchases for {theBox.ToString()}");
    Console.WriteLine(cicada.ToString());
    Console.Write("How many do you want to purchase ");
    double purchaseValue = 0;
    try
    {
        purchaseValue = cicada.purchase(int.Parse(Console.ReadLine()));
    }
    catch (FormatException) { Console.WriteLine("Input string invalid"); }
    try
    {
        Console.WriteLine(techDeck.ToString());
        Console.Write("How many do you want to purchase ");
        purchaseValue += techDeck.purchase(int.Parse(Console.ReadLine()));
        if (theBox is Employee)
        {
            purchaseValue -= (purchaseValue * 0.25);
        }
    }
    catch (FormatException) { Console.WriteLine("Input string invalid"); }
    Console.WriteLine($"Total purchase for {theBox.ToString()}: ${purchaseValue}");

    Console.WriteLine(cicada.ToString());
    Console.WriteLine(techDeck.ToString());
}

class Item
{
    string ID;
    string name;
    double price;
    int quantity;

    public Item(string itemID, string itemName, double itemPrice, int amountOnHand)
    {
        ID = itemID;
        name = itemName;
        price = itemPrice;
        quantity = amountOnHand;
    }
    public override string ToString()
    {
        return $"Item {ID} {name}, ${price:N2}, quantity: {quantity}";
    }
    public double purchase(int numberPurchased)
    {
        if (numberPurchased <= quantity)
        {
            double cost = price * numberPurchased;
            quantity = quantity - numberPurchased;
            return cost;
        }
        else 
        {
            Console.WriteLine("Not enough on hand");
            return 0;
        }
    }
}

class Employee
{
    string firstName;
    string lastName;
    string ID;

    public Employee(string employeeFirst, string employeeLast, string employeeID)
    {
        firstName = employeeFirst;
        lastName = employeeLast;
        ID = employeeID;
    }
    public override string ToString()
    {
        return $"{ID}, {firstName} {lastName}";
    }
}

class Customer
{
    string firstName;
    string lastName;
    string ID;

    public Customer(string customerFirst, string customerLast, string customerID)
    {
        firstName = customerFirst;
        lastName = customerLast;
        ID = customerID;
    }
    public override string ToString()
    {
        return $"{ID}, {firstName} {lastName}";
    }
}