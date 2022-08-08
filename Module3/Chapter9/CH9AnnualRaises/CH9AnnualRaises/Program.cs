Console.WriteLine("Chapter 9 Annual Raises by James Sales");


//Initiate struct here
Employee temp;
Employee emp1 = new Employee("Josh", "Beitler", "Salaried", 120000, 3, 15, 1998);
Employee emp2 = new Employee("James", "Sales", "Hourly", 21.5, 7, 27, 2020);
//Logic for struct
for (int k = 1; k < 3; k++)
{   // loop through pay cycles
    Console.WriteLine($"\nPay cycle {k}");
    for (int m = 1; m < 3; m++)
    {   // loop through employees
        if (m == 1) temp = emp1;
        else temp = emp2;
        // display employee info before raise
        temp.DisplayInfo();
        temp.AnnualRaise(2022, 4, 1);
        Console.WriteLine("After calculating raise:");
        temp.DisplayInfo();
        Console.WriteLine("");
        // calculate pay raise for temp
        // display employee info after pay raise
    }
    Console.WriteLine("Completed looping through employees");
}
//Initiate class here
Console.WriteLine("\nPart 2, Class");
ClassEmployee classTemp;
ClassEmployee classEmp1 = new ClassEmployee("Josh", "Beitler", "Salaried", 120000, 3, 15, 1998);
ClassEmployee classEmp2 = new ClassEmployee("James", "Sales", "Hourly", 21.5, 7, 27, 2020);
//logic for class
for (int k = 1; k < 3; k++)
{   // loop through pay cycles
    Console.WriteLine($"\nPay cycle {k}");
    for (int m = 1; m < 3; m++)
    {   // loop through employees
        if (m == 1) classTemp = classEmp1;
        else classTemp = classEmp2;
        // display employee info before raise
        classTemp.DisplayInfo();
        classTemp.AnnualRaise(2022, 4, 1);
        Console.WriteLine("After calculating raise:");
        classTemp.DisplayInfo();
        Console.WriteLine("");
        // calculate pay raise for temp
        // display employee info after pay raise
    }
    Console.WriteLine("Completed looping through employees");
}

Console.WriteLine("\nPress an any key, any of your choosing, to- no seriously, just any of the keys; to continue...");
Console.ReadKey();

struct Employee
{
    string firstName;
    string lastName;
    string payCategory;
    double payrate;
    Date hireDate;

    public Employee(string fName, string lName, string payType, double payRate, int hireM, int hireD, int hireY)
    {
        this.firstName = fName;
        this.lastName = lName;
        this.payCategory = payType;
        this.payrate = payRate;
        hireDate = new Date(hireM, hireD, hireY);
    }
    string FullName() => $"{firstName} {lastName}";
    public void DisplayInfo()
    {
        Console.WriteLine($"{FullName()}, {payCategory}, hired {hireDate.ToString()}, pay rate ${payrate:N2}");
    }
    public void AnnualRaise(int currentYear, double merit, double loyalty)
    {
        double meritRaise = (merit / 100) * payrate;
        int yearsOfService = currentYear - hireDate.year;
        double loyaltyRaise = (yearsOfService * (loyalty / 100)) * payrate;
        payrate = (payrate + loyaltyRaise + meritRaise);
    }
}

public class Date
{
    public int month;
    public int day;
    public int year;
    public Date(int month, int day, int year)
    {
        this.month = month;
        this.day = day;
        this.year = year;
    }

    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    public override string ToString()
    {
        //Use Months to get Month name.
        return $"{(Months)month} {day}, {year}";
    }
}