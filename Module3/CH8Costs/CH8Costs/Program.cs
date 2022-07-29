Console.WriteLine("Chapter 8 Costs by James Sales\n");
double subtotal = 0;
bool cont = true;
int enteredID;

Hardware mouse = new Hardware("RAZER GAMING MOUSE FOR GAMERS", 1146, 129.99);
Hardware keyboard = new Hardware("Generic free with computer USB keyboard (used)", 492, 0.35);
Repair display = new Repair("Display repair", 22, 49.95);
Repair charge = new Repair("Charging port repair", 19, 29.99);

Console.WriteLine(mouse.Display());
Console.WriteLine(keyboard.Display());
Console.WriteLine(display.Display());
Console.WriteLine(charge.Display());

while (cont)
{
    Console.Write("\nWhich one is being processed? ");
    enteredID = int.Parse(Console.ReadLine());
    Object obj;
    if (enteredID == mouse.ID)
    {
        obj = mouse;
    }
    else if (enteredID == keyboard.ID)
    {
        obj = keyboard;
    }
    else if (enteredID == display.ID)
    {
        obj = display;
    }
    else if (enteredID == charge.ID)
    {
        obj = charge;
    }
    else 
    {
        continue;
    }
    if (obj is Hardware)
    {
        Hardware hardware = (Hardware)obj;
        hardware.Calculation(ref subtotal);
    }
    else if (obj is Repair)
    {
        Repair repair = (Repair)obj;
        repair.Calculation(ref subtotal);
    }
    Console.Write("Do you want to process another one? (y/n) ");
    if (Console.ReadLine() == "n")
    {
        cont = false;
    }
}

Console.WriteLine("Press a key to continue");
Console.ReadKey();
class Hardware
{
    string name;
    public int ID;
    double price = 0;
    static double tax = 0.075;

    public Hardware(string hardwareName, int hardwareID, double hardwarePrice)
    {
        this.name = hardwareName;
        this.ID = hardwareID;
        this.price = hardwarePrice;
    }
    public double Calculation(ref double subtotal)
    {
        Console.Write("How many sold? ");
        int quantity = int.Parse(Console.ReadLine());
        subtotal = quantity * this.price;
        Console.WriteLine($"Subtotal = ${subtotal:N2}");
        Console.WriteLine($"Tax = ${subtotal * tax:N2}");
        double additionalCost = (subtotal * tax);
        Console.WriteLine($"Total Cost = ${(subtotal) + (subtotal * tax):N2}");
        return additionalCost;
    }
    public string Display()
    {
        return $"{this.ID} {this.name}";
    }
}

class Repair
{
    string name;
    public int ID;
    double price = 0;
    static double tax = 0.045;
    static double markup = 0.1;

    public Repair(string repairName, int repairID, double repairPrice)
    {
        this.name = repairName;
        this.ID = repairID;
        this.price = repairPrice;
    }
    public double Calculation(ref double subtotal)
    {
        subtotal = this.price;
        Console.WriteLine($"Subtotal = ${subtotal:N2}");
        Console.WriteLine($"Taxes and Fees = ${(subtotal * tax) + (subtotal * markup):N2}");
        double additionalCost = (subtotal * tax) + (subtotal * markup);
        Console.WriteLine($"Total Cost = ${(subtotal) + (subtotal * tax):n2}");
        return additionalCost;
    }
    public string Display()
    {
        return $"{this.ID} {this.name}";
    }
}