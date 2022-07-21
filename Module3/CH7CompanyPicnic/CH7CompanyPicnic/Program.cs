Console.WriteLine("Chapter 7 Company Picnic by James Sales");


//2 cash registers are needed
//one for tickets, one for food
//user specifies what they are buying and how much money they're offering
//project displays amount of change. 
//at the end the total sales for each is displayed and the grand total of both.
bool cont = true;
int quantityRequested = 0;
int raffleQuantity = 0;
string lineRead = "";
CashRegister foodRegister = new CashRegister();
CashRegister raffle = new CashRegister();
Food soda = new Food("soda", 2, 50);
Food hotDog = new Food("hot dog", 1.5, 300);
Food cottonCandy = new Food("cotton candy", 4.5, 75);

while (cont)
{
    //run logic
    //ask user what they're buying
    //use if else if to access the right object
    Console.Write("\nWhat are you buying, Raffle Ticket (r) or Food (f): ");
    lineRead = Console.ReadLine();
    if (lineRead == "r")
    {
        //run logic for raffle tickets
        Console.Write("Tickets are $5 each, how many are you buying? ");
        raffleQuantity = int.Parse(Console.ReadLine());
        raffle.NewSale(5, raffleQuantity);
    }
    else if (lineRead == "f")
    {
        //run logic for food
        Console.WriteLine("Food Choices (s, h, or c");
        soda.Display();
        hotDog.Display();
        cottonCandy.Display();
        Console.Write("Which food item do you want? (s, h, or c) ");
        lineRead = Console.ReadLine();
        if (lineRead == "s")
        {
            Console.Write("How many do you want? ");
            quantityRequested = int.Parse(Console.ReadLine());
            if (quantityRequested < soda.quantityOnHand)
            {
                foodRegister.NewSale(soda.cost, quantityRequested);
            }
            else
            {
                Console.WriteLine("We don't have enough in stock");
            }

        }
        else if (lineRead == "h")
        {
            Console.Write("How many do you want? ");
            quantityRequested = int.Parse(Console.ReadLine());
            if (quantityRequested < hotDog.quantityOnHand)
            {
                foodRegister.NewSale(hotDog.cost, quantityRequested);
            }
            else
            {
                Console.WriteLine("We don't have enough in stock");
            }
        }
        else if (lineRead == "c")
        {
            Console.Write("How many do you want? ");
            quantityRequested = int.Parse(Console.ReadLine());
            if (quantityRequested < cottonCandy.quantityOnHand)
            {
                foodRegister.NewSale(cottonCandy.cost, quantityRequested);
            }
            else
            {
                Console.WriteLine("We don't have enough in stock");
            }
        }
    }
    Console.Write("More purchases? (y/n) ");
    if (Console.ReadLine() == "n")
    {
        cont = false;
    }
}
Console.WriteLine("\nAt the end of the picnic:");
Console.WriteLine($"Raffle Tickets Total Sales: ${raffle.total:N2}");
Console.WriteLine($"Food Total Sales: ${foodRegister.total:N2}");
Console.WriteLine($"Grand Total: ${raffle.total + foodRegister.total:N2}\n");

Console.WriteLine("\nPress any key to continue");
Console.ReadKey();

//Cash register object


//food object
class Food
{
    string name = "";
    public int quantityOnHand = 0;
    public double cost = 0;
    public Food(string name, double cost, int quantityOnHand)
    {
        this.name = name;
        this.cost = cost;
        this.quantityOnHand = quantityOnHand;
        //Food Constructor

    }
    public void Display()
    {
        //I can't tell if the brief states what to do here so this is what I'm using it for.
        Console.WriteLine($"{name} ${cost}");
    }
}

class CashRegister
{
    public double total = 0;
    double cost = 0;
    double tender = 0;
    double change = 0;
    
    public CashRegister()
    {
        //Constructor
    }
    
    public void NewSale(double itemCost, int quantity)
    {
        this.cost = itemCost * quantity;
        Console.Write($"That costs ${cost:N2}, how much are you paying? ");
        tender = double.Parse(Console.ReadLine());
        Change();
    }
    public void Change()
    {
        change = tender - cost;
        if (change < 0)
        {
            Console.WriteLine("No sale, you didn't pay enough for items");
        }
        else
        {
            Console.WriteLine($"The change is ${change:N2}");
            total = total + cost;
        }
    }
}