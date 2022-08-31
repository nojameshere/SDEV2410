using System.Collections;
Console.WriteLine("SDEV 2410 Final Project by James Sales");

ArrayList marketingItems = new ArrayList();
ArrayList shippingItems = new ArrayList();

marketingItems.Add(new Marketing("P290", "Toaster", 200, 49.95, 0));
marketingItems.Add(new Marketing("P104", "Poster", 35, 2.99, 2));
marketingItems.Add(new Marketing("P941", "Ceramic Mug", 15, 29.99, 1));
marketingItems.Add(new Marketing("P51", "Model Plane", 45, 35.99, 0));

shippingItems.Add(new Shipping("S123", "Leeds", 30, 4713, 10, 4.6, 73, 375));
shippingItems.Add(new Shipping("S591", "Moscow", 120, 5529, 128, 60, 60, 10300)); //This is the rate you'd get shipping Moscow all of the nukes made prior to 1949. In case you needed to know.
shippingItems.Add(new Shipping("S2001", "Drury Lane", 1, 206, 38.3, 20, 63.7, 170.6));
shippingItems.Add(new Shipping("S2001S", "Europa", 6, 729, 55, 78.3, 900, 11000));

Console.WriteLine("\nFirst Part: Purchasing Products");
foreach(Marketing item in marketingItems)
{
    item.TierRate();
    item.FlatRate();
}
Console.WriteLine("\nSummary:");
Console.WriteLine($"   Straight Cost: {Marketing.straightCosts:c}");
Console.WriteLine($"Volume Discounts: {Marketing.volumeDiscounts:c}");
Console.WriteLine($"   Cart Discount: {Marketing.cartDiscount:c}");

Console.WriteLine("\nSecond Part: Shipping");
foreach(Shipping item in shippingItems)
{
    item.TierRate();
    item.FlatRate();
}
Console.WriteLine("\nSummary");
Console.WriteLine($"Zone shipping costs: {Shipping.zoneRate:c}");
Console.WriteLine($"Flat rate cost: {Shipping.flatRate:c}");

Console.WriteLine("\nThank you so much for a-playing-a my game! (to be read in a Mario voice)");
Console.ReadKey();

static class Globals
{
    public static double[,] tier1 = new double[,] { { 50, 20.00 }, { 30, 10.00 }, { 15, 5.00 } };
    public static double[,] tier2 = new double[,] { { 20, 12.00 }, { 10, 8.00 }, { 5, 3.00 } };
    public static double[,] tier3 = new double[,] { { 150, 20.00 }, { 100, 10.00 }, { 50, 5.00 } };
    public static double[,] shipingRates = new double[,] { { 1000, 50 }, { 500, 35 }, { 100, 20 } };

    public static int CheckTier(double[,] tier, int quantity)
    {
        if (quantity > tier[0, 0])
        {
            return 0;
        }
        else if (quantity > tier[1, 0])
        {
            return 1;
        }
        else if (quantity > tier[2, 0])
        {
            return 2;
        }
        else return -1;
    }

}

interface Discount
{
    void TierRate();
    void FlatRate();
}

abstract class Item : Discount
{
    protected string ID, name;
    protected int quantity;
    public Item(string ID, string name, int quantity)
    {
        this.ID = ID;
        this.name = name;
        this.quantity = quantity;
    }
    public abstract void TierRate();
    public abstract void FlatRate();
    public override string ToString()
    {
        return $"{ID} {name}";
    }
}

class Marketing : Item
{
    public static double straightCosts = 0;
    public static double volumeDiscounts = 0;
    public static double cartDiscount = 0;
    double flat = 0.1;
    double cost;
    int tier;
    public Marketing(string ID, string name, int quantity, double cost, int tier)
        : base (ID, name, quantity)
    {
        this.cost = cost;
        this.tier = tier;
    }
    public override void FlatRate()
    {
        double wholeCart = (cost * quantity) * flat;
        Console.WriteLine($"Whole cart discount: {wholeCart:c}");
        Console.WriteLine($"Cost after cart discount: {(cost * quantity) - wholeCart:c}");
        straightCosts += (cost * quantity);
        cartDiscount += (cost * quantity) - wholeCart;
    }
    public override void TierRate()
    {
        int tierReturn;
        double discount = 0 ;
        switch (tier)
        {
            case 0:
                //code for tier 1
                tierReturn = Globals.CheckTier(Globals.tier1, quantity);
                if (tierReturn > -1)
                {
                    discount = Globals.tier1[tierReturn, 1] / 100;
                }
                Console.WriteLine($"\n{ToString()}");
                Console.WriteLine("Discount options:");
                Console.WriteLine($"\t{Globals.tier1[0,0]} at {Globals.tier1[0,1]}%, {Globals.tier1[1, 0]} at {Globals.tier1[1, 1]}%, {Globals.tier1[2, 0]} at {Globals.tier1[2, 1]}%");
                Console.WriteLine($"Cost without discount: {cost * quantity:c}");
                Console.WriteLine($"Volume rate: {Globals.tier1[tier, 1]}%, discount: {(cost * quantity) * discount:c}");
                Console.WriteLine($"Cost after Volume discount: {(cost * quantity) - ((cost * quantity) * discount):c}");
                break;
            case 1:
                //code for tier 2
                tierReturn = Globals.CheckTier(Globals.tier2, quantity);
                if (tierReturn > -1)
                {
                    discount = Globals.tier1[tierReturn, 1] / 100;
                }
                Console.WriteLine($"\n{ToString()}");
                Console.WriteLine("Discount options:");
                Console.WriteLine($"\t{Globals.tier2[0, 0]} at {Globals.tier2[0, 1]}%, {Globals.tier2[1, 0]} at {Globals.tier2[1, 1]}%, {Globals.tier2[2, 0]} at {Globals.tier2[2, 1]}%");
                Console.WriteLine($"Cost without discount: {cost * quantity:c}");
                Console.WriteLine($"Volume rate: {Globals.tier2[tier, 1]}%, discount: {(cost * quantity) * discount:c}");
                Console.WriteLine($"Cost after Volume discount: {(cost * quantity) - ((cost * quantity) * discount):c}");
                break;
            case 2:
                //code for tier 3
                tierReturn = Globals.CheckTier(Globals.tier3, quantity);
                if (tierReturn > -1)
                {
                    discount = Globals.tier1[tierReturn, 1] / 100;
                }
                Console.WriteLine($"\n{ToString()}");
                Console.WriteLine("Discount options:");
                Console.WriteLine($"\t{Globals.tier3[0, 0]} at {Globals.tier3[0, 1]}%, {Globals.tier3[1, 0]} at {Globals.tier3[1, 1]}%, {Globals.tier3[2, 0]} at {Globals.tier3[2, 1]}%");
                Console.WriteLine($"Cost without discount: {cost * quantity:c}");                Console.WriteLine($"Volume rate: {Globals.tier3[tier, 1]}%, discount: {(cost * quantity) * discount:c}");
                Console.WriteLine($"Cost after Volume discount: {(cost * quantity) - ((cost * quantity) * discount):c}");
                break;
            default:
                Console.WriteLine("Item is not assigned a correct tier, please assign correct tier");
                break;
        }
        volumeDiscounts += (cost * quantity) - ((cost * quantity) * discount);
    }
    public override string ToString()
    {
        return $"{base.ToString()}: cost {cost:c}, quantity {quantity}";
    }
    
}

class Shipping : Item
{
    public static double zoneRate = 0;
    public static double flatRate = 0;
    int distance;
    double l, w, h, weight;
    public Shipping(string ID, string name, int quantity, int distance, double l, double w, double h, double weight)
        : base(ID, name, quantity)
    {
        this.distance = distance;
        this.l = l;
        this.w = w;
        this.h = h;
        this.weight = weight;
    }
    public override void TierRate()
    {
        int tierReturn;
        double discount = 10;
        //yee
        Console.WriteLine($"\n{ToString()}");
        Console.WriteLine("Zone rates:");
        Console.WriteLine($"\t{Globals.shipingRates[0, 0]}mi at {Globals.shipingRates[0, 1]:c}, {Globals.shipingRates[1, 0]}mi at {Globals.shipingRates[1, 1]:c}, {Globals.shipingRates[2, 0]}mi at {Globals.shipingRates[2, 1]:c},");
        tierReturn = Globals.CheckTier(Globals.shipingRates, distance);
        if (tierReturn > -1)
        {
            discount = Globals.shipingRates[tierReturn, 1] * quantity;
        }
        Console.WriteLine($"Zone rate: {Globals.shipingRates[tierReturn, 1]:c}, ship cost: {discount:c}");
        zoneRate += discount;
    }
    public override void FlatRate()
    {
        //he yaw...
        Console.WriteLine($"Flate rate cost: {quantity * 35:c}");
        flatRate += (quantity * 35);
    }
    public override string ToString()
    {
        return $"{base.ToString()}: {quantity} boxes, distance {distance} miles. \nSize: {l} x {w} x {h}, weight {weight}";
    }
}