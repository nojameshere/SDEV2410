Console.WriteLine("Chapter 11 Sales Quotas by James Sales");

Employee james = new Employee("James", "Sales", 3500);
Employee josh = new Employee("Josh", "Beitler", 15000);
Employee clint = new Employee("Clint", "Betts", 45000);
Employee cory = new Employee("Cory", "Coleman", 11000);
Employee michael = new Employee("Michael", "Brewer", 156000);
Employee[] employees = {james, josh, clint, cory, michael};

//The arrays don't have to be created when calling, just pass in the values to be added
//I struggled with that fact and after about 2 hours researching I deleted what I had and it worked...
checkSales(james, 1200, 300, 900 );
checkSales(josh, 4500, 10000, 650, 112);
checkSales(clint, 13000, 10000, 15000);
checkSales(cory, 11456, 1928, 103, 205, 11190);
checkSales(michael, 10923, 2180, 18);

Console.WriteLine("\nPress any key to continue");
Console.ReadKey();
void checkSales(Employee empName, params int[] sales)
{
    double total = 0;
    Console.WriteLine(empName.Display());
    for(int i = 0; i < sales.Length; i++)
    {
        Console.Write($"{sales[i]:c}  ");
        total += sales[i];
    }
    Console.WriteLine($"\nTotal: {total:c}");
    if(total >= empName.quota)
    {
        Console.WriteLine($"Good job, {empName.first}, you made your quota of {empName.quota:c}");
    }
    else
    {
        Console.WriteLine($"{empName.first}, you did not make your quota of {empName.quota:c}");
    }
}

struct Employee
{
    public string first;
    string last;
    public double quota;
    public Employee(string fname, string lname, double quota)
    {
        this.first = fname;
        this.last = lname;
        this.quota = quota;
    }
    public string Display() { return $"\nFor Employee {first} {last}"; }
}