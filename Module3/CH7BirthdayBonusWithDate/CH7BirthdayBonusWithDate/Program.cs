Console.WriteLine("Chapter 7 Birthday Bonus, Payroll with Date by James Sales\n");

//Application for monthly payroll. Add $100 extra if its their birth month.
//Needs 2 classes(date and employee) Employee class needs a Date object with their birthday

Employee empOne = new Employee(123, "James", "Sales", 31.5, 40, 1, 15, 1997);
Employee empTwo = new Employee(456, "Tamara", "Smith", 49.63, 35, 2, 19, 1986);
Employee empThree = new Employee(678, "Alan", "Carter", 11.72, 19, 3, 1, 2000);

for(int i = 1; i < 4; i++)
{
    Console.WriteLine($"\nCalculating pay for month {i}");
    empOne.monthlyPay(i);
    empTwo.monthlyPay(i);
    empThree.monthlyPay(i);
    Console.WriteLine($"\nTotal Pay for this month: ${Employee.monthPay:N2}");
    Employee.allPay = Employee.allPay + Employee.monthPay;
    Employee.monthPay = 0;
}
Console.WriteLine($"\nTotal Pay for all months: ${Employee.allPay:N2}\n");
Console.WriteLine("Press an any key to continue");
Console.ReadKey();
public class Date
{
    int year = 0;
    public int month = 0;
    int day = 0;
    public Date(int MM, int DD, int YYYY)
    {
        this.year = YYYY;
        this.month = MM;
        this.day = DD;
    }
    public string Display()
    {
        return $"{this.month}/{this.day}/{this.year}";
    }
}

class Employee
{
    public static double monthPay = 0;
    public static double allPay = 0;
    string nameFirst;
    string nameLast;
    int birthMonth = 0;
    double payrate = 0;
    double hoursWorked = 0;
    int empID = 0;
    string birthDate;
    public Employee(int empID, string nameFirst, string nameLast, double payRate, double hoursWorked, int MM, int DD, int YYYY)
    {
        this.nameFirst = nameFirst;
        this.nameLast = nameLast;
        this.payrate = payRate;
        this.hoursWorked = hoursWorked;
        Date birthday = new Date(MM, DD, YYYY);
        this.birthMonth = birthday.month;
        this.empID = empID;
        this.birthDate = birthday.Display();
        dispEmpInfo();
    }
    public string buildName() => $"{nameFirst} {nameLast}";
    public void dispEmpInfo()
    {
        Console.WriteLine($"Employee {empID}, {buildName()}, birthday {birthDate}, pay rate ${payrate:N2}");
    }
    public void monthlyPay(int month)
    {
        double pay = payrate * (hoursWorked * 4);
        if (month == birthMonth)
        {
            Console.WriteLine($"Gross Pay for {buildName()}: ${pay + 100:N2} with birthday bonus");
            monthPay = monthPay + (pay + 100);
        }
        else
        {
            Console.WriteLine($"Gross Pay for {buildName()}: ${pay:N2}");
            monthPay = monthPay + pay;
        }
    }
}