using static System.Console;
WriteLine("Chapter 3 Payroll by James Sales");
bool continuePayroll = true;
while (continuePayroll)
{
    empPayroll();
    Console.Write("Do you have another employee to process? (y/n) ");
    if (Console.ReadLine() == "n")
    {
        continuePayroll = false;
    }
}
static string getInfo()
{
    //Prompts the user for all the employee information.
    Write("\nWhat is the employee's ID? ");
    string empID = ReadLine();
    Write("What is the employee's first name? ");
    string first = ReadLine();
    Write("What is the employee's last name? ");
    string last = ReadLine();
    return $"Payroll for {empID} {first} {last}";
}
static double getPay()
{
    //Prompts user for pay information and hours worked then returns gross pay.
    double payRate = 0;
    double hoursWorked = 0;
    do
    {
        Write("What is the employee's rate of pay? $");
        payRate = double.Parse(ReadLine());
    } while (payRate < 1 || payRate > 50);
    do
    {
        Write("How many hours did the employee work? ");
        hoursWorked = double.Parse(ReadLine());
    } while (hoursWorked < 1 || hoursWorked > 60);
    double grossPay = payRate * hoursWorked;
    return (grossPay);
}
static void empPayroll()
{
    string payrollString = getInfo();
    double grossPay = getPay();
    double FICA(double gross)
    {
        double tax = gross * .075;
        return tax;
    }
    double net = grossPay - FICA(grossPay);
    WriteLine(payrollString);
    WriteLine($"   Gross Pay {grossPay:C}");
    WriteLine($"   FICA tax  {FICA(grossPay):C}");
    WriteLine($"   Net Pay   {net:C}");
}


//Because recursion has not been covered we're going to just call the method 3 times.

Write("\nPress the any key to continue...");
ReadKey();