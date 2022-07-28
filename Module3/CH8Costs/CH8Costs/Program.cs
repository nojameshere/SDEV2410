Console.WriteLine("Chapter 8 Costs by James Sales");
double subtotal = 0;
bool cont = true;

Hardware mouse = new Hardware("RAZER GAMING MOUSE FOR GAMERS", 1146, 129.99);
Hardware keyboard = new Hardware("Generic free with computer USB keyboard (used)", 492, 0.35);
Repair display = new Repair("Display repair", 22, 49.95);
Repair charge = new Repair("Charging port repair", 19, 29.99);



while (cont)
{
//Some shit here about doing shit


}





class Hardware
{
    string name;
    int ID;
    double price = 0;
    double tax = 0.075;

    public Hardware(string hardwareName, int hardwareID, double hardwarePrice)
    {
        this.name = hardwareName;
        this.ID = hardwareID;
        this.price = hardwarePrice;
    }
    public double Calculation(ref subtotal)
    {
        Console.Write("How many sold? ");
        int quantity = int.Parse(Console.ReadLine());
        subtotal = quantity * this.price;
        Console.WriteLine($"Subtotal = {subtotal}";
        Console.WriteLine($"Tax = {subtotal * this.tax}");
        double totalCost = subtotal + (subtotal * this.tax);
        Console.WriteLine($"Total Cost = {(subtotal) + (subtotal * this.tax)}");
        return totalCost
    }
    public string Display()
    {
        return $"{this.ID} {this.name}";
    }
}

class Repair
{
    string name;
    int ID;
    double price = 0;
    static double tax = 0.045;
    static double markup = 0.1;

    public Repair(string repairName, int repairID, double repairPrice)
    {
        this.name = repairName;
        this.ID = repairID;
        this.price = repairPrice;
    }
    public double Calculation(ref subtotal)
    {
        Console.Write("How many sold? ");
        int quantity = int.Parse(Console.ReadLine());
        subtotal = quantity * this.price;
        Console.WriteLine($"Subtotal = {subtotal}";
        Console.WriteLine($"Taxes and Fees = {(subtotal * this.tax) + (subtotal * this.markup)}");
        double totalCost = subtotal + (subtotal * this.tax) + (subtotal * this.markup);
        Console.WriteLine($"Total Cost = {(subtotal) + (subtotal * this.tax)}");
        return totalCost
    }
    public string Display()
    {
        return $"{this.ID} {this.name}";
    }
}