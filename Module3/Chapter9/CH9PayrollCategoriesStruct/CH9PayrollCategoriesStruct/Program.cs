Console.WriteLine("Chapter 9 Payroll Categories using Struct by James Sales\n");
int workedHours = 0;

Console.WriteLine("Input for salatied employee");
Employee salaried = new Employee();
Console.Write("Enter first name: ");
salaried.firstName = Console.ReadLine();
Console.Write("Enter last name: ");
salaried.lastName = Console.ReadLine();
Console.Write("Enter annual pay: $");
try
{
    salaried.wage = double.Parse(Console.ReadLine());
}
catch(FormatException)
{
    Console.WriteLine("Input string not in correct format. Try again.");
}
Employee hourly = new Employee();
Console.Write("\nEnter first name: ");
hourly.firstName = Console.ReadLine();
Console.Write("Enter last name: ");
hourly.lastName = Console.ReadLine();
Console.Write("Enter hourly pay: $");
try
{
    hourly.wage = double.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Input string not in correct format.");
}
Console.Write("Enter number of hours worked: ");
try
{
    workedHours = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Input string not in correct format.");
}
salaried.weeklyPay();
hourly.weeklyPay(workedHours);
Console.WriteLine("\nPress any key to continue");
Console.ReadKey();
struct Employee
{
    public string firstName;
    public string lastName;
    public double wage;
    public string fullName() => $"{firstName} + {lastName}";

    public void weeklyPay()
    {
        double pay = wage / 52;
        Console.WriteLine($"\nEmployee {fullName()}, weekly pay: ${pay:N2}");
    }
    public void weeklyPay(int hoursWorked)
    {
        double pay = wage * hoursWorked;
        Console.WriteLine($"\nEmployee {fullName()}, weekly pay: ${pay:N2}");
    }
}