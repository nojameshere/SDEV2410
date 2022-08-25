Console.WriteLine("Chapter 13 Payroll with Abstract Class by James Sales");

Employee[] employees = new Employee[6];
employees[0] = new Hourly(113, "James", "Sales", 21.5, 40);
employees[1] = new Hourly(293, "Josh", "Beitler", 65.75, 40);
employees[2] = new Salary(458, "Clint", "Betts", 139000);
employees[3] = new Salary(190, "Michael", "Scott", 41000);
employees[4] = new Commission(999, "Steven", "Fry", 139000, 2);
employees[5] = new Commission(643, "Bob", "McBuilder", 1400, 3.6);

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.ToString());
    employee.calcPay();
}

Console.WriteLine("\nDrücken Sie eine beliebige Taste, um fortzufahren");
Console.ReadKey();

abstract class Employee
{
    protected static double totalPay = 0;
    int ID;
    string first, last;
    protected Employee(int ID, string first, string last)
    {
        this.ID = ID;
        this.first = first;
        this.last = last;
    }
    protected string DisplayName() => $"{first} {last}";
    public override string ToString()
    {
        return $"{ID} {first} {last}";
    }
    public abstract void calcPay();
}

//need Hourly, Salary, and Commission.

class Hourly : Employee
{
    double wage;
    int hoursWorked;
    public Hourly(int ID, string first, string last, double wage, int hoursWorked)
        : base (ID, first, last)
    {
        this.wage = wage;
        this.hoursWorked = hoursWorked;
    }
    public override string ToString()
    {
        return $"\nHourly employee: {base.ToString()}";
    }
    public override void calcPay()
    {
        double pay = wage * hoursWorked;
        totalPay += pay;
        Console.WriteLine($"\tHourly pay rate: {wage:c}");
        Console.WriteLine($"\tHours worked: {hoursWorked}");
        Console.WriteLine($"\tEarned: {pay:c}");
    }
}

class Salary : Employee
{
    double annualPay;
    public Salary(int ID, string first, string last, double annualPay)
        : base (ID, first, last)
    {
        this.annualPay = annualPay;
    }
    public override string ToString()
    {
        return $"\nSalaried employee: {base.ToString()}";
    }
    public override void calcPay()
    {
        double pay = annualPay / 12;
        Console.WriteLine($"\tEarned: {pay:c}");
        totalPay += pay;
    }
}

class Commission : Employee
{
    double sales;
    double rate;
    public Commission(int ID, string first, string last, double sales, double rate)
        : base (ID, first, last)
    {
        this.sales = sales;
        this.rate = rate;
    }
    public override string ToString()
    {
        return $"\nCommission employee: {base.ToString()}";
    }
    public override void calcPay()
    {
        Console.WriteLine($"\tCommission rate: %{rate}");
        Console.WriteLine($"\tSales: {sales:c}");
        double pay = sales * (rate / 100);
        Console.WriteLine($"\tEarned: {pay:c}");
        totalPay += pay;
    }
}