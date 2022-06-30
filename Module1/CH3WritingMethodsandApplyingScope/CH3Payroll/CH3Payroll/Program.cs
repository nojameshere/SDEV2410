using static System.Console;
WriteLine("Chapter 3 Payroll by James Sales");

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
    Write("What is the employee's rate of pay? $");
    double payRate = double.Parse(ReadLine());
    Write("How many hours did the employee work? ");
    double hoursWorked = double.Parse(ReadLine());
    double grossPay = payRate * hoursWorked;
    return(grossPay);
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
empPayroll();
empPayroll();
empPayroll();

Write("\nPress the any key to continue...");
ReadKey();



//Three methods...
//First method asks for all information -DONE
//Second asks for the pay information and calculate gross pay -DONE
//Third prints the results
//Third needs to have a method to calculate FICA tax -DONE