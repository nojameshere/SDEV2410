Console.WriteLine("Chapter 13, Greater Than Interface, by James Sales");

EmployeePay emp1 = new EmployeePay(123, 40, 21.5);
EmployeePay emp2 = new EmployeePay(234, 35, 48.25);
Inventory item1 = new Inventory(567, "Toaster", 69.99, 420);
Inventory item2 = new Inventory(678, "Oven", 399.93, 4700);

Console.WriteLine("\nCheck out Greater with Payroll objects");
emp1.displayGreater(emp2);
Console.WriteLine("\nChange hours for first employee");
emp1.setHours(600);
emp1.displayGreater(emp2);
Console.WriteLine("\nCheck out Greater with Inventory objects");
item1.displayGreater(item2);
Console.WriteLine("\nReduce quantity for second item");
item2.reduceQuantity(3);
item1.displayGreater(item2);

Console.WriteLine("\nPress a key please");
Console.ReadKey();
interface IGreater
{
    Boolean IsGreater(Object obj);
    void displayGreater(Object obj);
}

class EmployeePay : IGreater
{
    int ID, hours;
    double rate;
    public double gross;
    public EmployeePay(int ID, int hours, double rate)
    {
        this.ID = ID;
        this.hours = hours;
        this.rate = rate;
        this.gross = hours * rate;
    }
    public Boolean IsGreater(Object obj)
    {
        EmployeePay temp = (EmployeePay)obj;
        return gross > temp.gross; //The > evaluates as true or false, it can be returned instead of checking first.. neat.
    }
    public void displayGreater(Object obj)
    {

        EmployeePay temp = (EmployeePay)obj;
        Console.WriteLine(this.ToString());
        Console.WriteLine(temp.ToString());
        if (IsGreater(temp))
        {
            Console.WriteLine($"Pay for employee {this.ID} is greater than pay for employee {temp.ID}");
        }
        else { Console.WriteLine($"Pay for employee {temp.ID} is greater than pay for employee {this.ID}"); }

    }
    public override string ToString()
    {
        return $"Employee {ID}: rate {rate:c}, hours {hours}, gross pay {gross:c}";
    }
    public void setHours(int newHours)
    {
        hours = newHours;
        gross = hours * rate;
    }
}
class Inventory : IGreater
{
    int ID, quantity;
    double cost;
    public double value;
    string name;
    public Inventory(int ID, string name, double cost, int quantity)
    {
        this.ID = ID;
        this.name = name;
        this.cost = cost;
        this.quantity = quantity;
        this.value = cost * quantity;
    }
    public Boolean IsGreater(Object obj)
    {
        Inventory temp = (Inventory)obj;
        return value > temp.value;
    }
    public void displayGreater(Object obj)
    {
        Inventory temp = (Inventory)obj;
        Console.WriteLine(this.ToString());
        Console.WriteLine(temp.ToString());
        if (IsGreater(temp))
        {
            Console.WriteLine($"Item {this.name} has more warehouse value than item {temp.name}");
        }
        else { Console.WriteLine($"Item {temp.name} has more warehouse value than item {this.name}"); }
    }
    public override string ToString()
    {
        return $"{ID} {name} costs {cost:c}, qty on hand {quantity}, value {value:c}";
    }
    public void reduceQuantity(int newQuantity)
    {
        quantity = newQuantity;
        value = cost * quantity;
    }
}