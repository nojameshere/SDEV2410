Console.WriteLine("Chapter 9 Annual Raises by James Sales");





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
        Console.WriteLine($"{FullName()}, {payCategory}, hired {hireDate.ToString()}, pay rate ${payrate}");
    }
    void AnnualRaise()
    {

    }
}

class Date
{
    int month;
    int day;
    int year;
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
        return "Month day, year";
    }
}