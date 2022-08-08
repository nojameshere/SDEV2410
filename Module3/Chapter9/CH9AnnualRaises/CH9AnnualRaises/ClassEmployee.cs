internal class ClassEmployee
{

    string firstName;
    string lastName;
    string payCategory;
    double payrate;
    Date hireDate;

    public ClassEmployee(string fName, string lName, string payType, double payRate, int hireM, int hireD, int hireY)
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