Console.WriteLine("Chapter 10 Employee Payroll Array by James Sales\n");

Console.WriteLine("Input data about employees");

//Creates an array with 5 Employee Objects.
int size = 5;
Employee[] employees = new Employee[size];

//Adds 5 new employees to the array 
for (int i = 0; i < 5; i++)
{
    string first, last;
    double pay;
    int hours;
    Console.WriteLine($"\nFor employee #{i + 1}");
    Console.Write("Enter first name: ");
    first = Console.ReadLine();
    Console.Write("Enter last name: ");
    last = Console.ReadLine();
    try
    {
        Console.Write("Enter rate of pay: ");
        pay = double.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input string format. Setting pay rate to $0");
        pay = 0;
    }
    try
    {
        Console.Write("Enter hours worked: ");
        hours = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input string format. Setting hours to 0");
        hours = 0;
    }
    Employee temp = new Employee(first, last, pay, hours);
    //Employee is added here.
    employees[i] = temp;
}
Console.WriteLine("\nPayroll");
//Runs the Display() method for each employee in the array.
foreach (Employee employee in employees)
{
    Console.WriteLine($"{employee.Display()}");
}
Console.WriteLine("");
//Because this is a static method the class name is used instead of arrayName[Index#].methodName()
Console.WriteLine($"Total Pay: {Employee.returnTotalPay()}");

Console.WriteLine("\nPress any key to continue...");
Console.ReadKey();


struct Employee
{
    static double totalPay;
    string fName, lName;
    int hoursWorked;
    double payRate;

    public Employee(string first, string last, double pay, int hours)
    {
        this.fName = first;
        this.lName = last;
        this.hoursWorked = hours;
        this.payRate = pay;
    }
    public string fullName() => $"{fName} {lName}";

    public string Display()
    {
        return $"{fullName()}: pay rate {payRate:C}, worked {hoursWorked} hours, gross pay = {calcPay():C}";
    }
    public double calcPay()
    {
        double calculatedPay = hoursWorked * payRate;
        if (hoursWorked > 40)
        {
            int overtime = hoursWorked - 40;
            calculatedPay += (overtime * payRate);
        }
        totalPay += calculatedPay;
        return calculatedPay;
    }
    public static string returnTotalPay() => $"{totalPay:C}";
}