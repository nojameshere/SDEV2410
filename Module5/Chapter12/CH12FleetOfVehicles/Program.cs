Console.WriteLine("Chapter 11 Fleet of Vehicles by James Sales\n");
bool cont = true;

Vehicle[] vehicles= new Vehicle[6];
vehicles[0] = new Car(2002, "Yellow", "Mini", "Cooper", "Gasoline", 2, "sunroof");
vehicles[1] = new Car(2009, "Blue", "Honda", "CRV", "Gasoline", 4, "sunroof");
vehicles[2] = new Truck(1999, "Orange", "Toyota", "Tacoma", "Disel", 2, 72, "No bedliner");
vehicles[3] = new Truck(2022, "White", "Ford", "Maverick", "Hybrid", 4, 60, "Bedliner");
vehicles[4] = new Car(2023, "White", "Tesla", "Model 3", "Electric", 4, "sunroof");
vehicles[5] = new Truck(1993, "Whire", "Honda", "ACTY", "Gasoline", 2, 72, "No bedliner");

foreach (Vehicle vehicle in vehicles)
    Console.WriteLine(vehicle.ToString());

while (cont)
{
    Console.Write("\nWhat type of vehicle do you want to see? (c)Car, (t)Truck, or (d)Done? ");
    string userResponse = Console.ReadLine();
    switch (userResponse)
    {
        case "c":
            //Code for showing cars
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Car)
                {
                    Console.WriteLine(((Car)vehicle).ToString());
                }
            }
            break;
        case "t":
            //code for showing trucks
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Truck)
                {
                    Console.WriteLine(((Truck)vehicle).ToString());
                }
            }
            break;
        case "d":
            //Ask user for year, display all the objects from that year
            Console.Write("Enter a model year ");
            int userYear = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if(userYear == vehicle.year)
                {
                    Console.WriteLine(vehicle.ToString());
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No vehicles of that year in list");
            }
            //code for the last query, probably what make, who knows.
            Console.Write("Enter a make ");
            userResponse = Console.ReadLine();
            count = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (userResponse == vehicle.make)
                {
                    Console.WriteLine(vehicle.ToString());
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No vehicles of that make");
            }
            //code for exiting the program
            cont = false;
            break;
        default:
            Console.WriteLine("That is not a valid selection");
            break;
    }
}

Console.WriteLine("\nPress a key to continue");
Console.ReadKey();



class Vehicle
{
    public int year;
    public string color;
    public string make;
    public string model;
    public string engineType;
    public int doors;
    public Vehicle(int year, string color, string make, string model, string engineType, int doors)
    {
        this.year = year;
        this.color = color;
        this.make = make;
        this.model = model;
        this.engineType = engineType;
        this.doors = doors;
    }
    public override string ToString()
    {
        return $"{year} {color} {make} {model}, {engineType} engine, {doors} doors,";
    }
}

class Truck :Vehicle
{
    int bedLength;
    string bedLiner;
    public Truck(int year, string color, string make, string model, string engineType, int doors, int bedLength, string bedLiner)
        : base(year, color, make, model, engineType, doors)
    {
        this.bedLength = bedLength;
        this.bedLiner = bedLiner;
    }
    public override string ToString()
    {
        return $"{base.ToString()} bed length: {bedLength}, {bedLiner}";
    }
}

class Car :Vehicle
{
    string sunroof;

    public Car(int year, string color, string make, string model, string engineType, int doors, string sunroof)
        :base (year, color, make, model, engineType, doors)
    {
        
        this.sunroof = sunroof;
    }
    public override string ToString()
    {
        return $"{base.ToString()} {sunroof}";
    }
}