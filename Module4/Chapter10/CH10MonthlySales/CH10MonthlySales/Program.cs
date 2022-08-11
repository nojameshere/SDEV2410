Console.WriteLine("Chapter 10 Monthly Sales Using 2D Array by James Sales\n");
bool cont = true;
int size = 4;
Employee[] people= new Employee[size];
people[0] = new Employee("James", "Sales", 569);
people[1] = new Employee("Josh", "Beitler", 883);
people[2] = new Employee("Clint", "Betts", 138);
people[3] = new Employee("Melody", "West", 429);
double[,] sales =
{
    {45.8, 32.6, 99.5 },
    {65.7, 11.4, 0.18 },
    {21.8, 36.6, 11.4 },
    {44.6, 10.9, 59.4 }
};
for(int i = 0; i < 4; i++)
{
    Console.WriteLine($"{people[i].printInfo()}: \t\t{sales[i, 0]:c}\t\t{sales[i, 1]:c}\t\t{sales[i, 2]:c}");
}
while (cont)
{
    Console.Write("\nPrint (s)Sales totals for staff, (m)Monthly sales totals, (x)Exit: ");
    string response = Console.ReadLine();
    switch (response)
    {
        case "s":
            //logic for sales
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{people[i].printInfo()}: \t\t{sales[i, 0] + sales[i, 1] + sales[i, 2]:c}");
            }
            break;
        case "m":
            //logic for monthly sales totals
            double monthOne = sales[0, 0] + sales[1, 0] + sales[2, 0] + sales[3, 0];
            double monthTwo = sales[0, 1] + sales[1, 1] + sales[2, 1] + sales[3, 1];
            double monthThree = sales[0, 2] + sales[1, 2] + sales[2, 2] + sales[3, 2];
            Console.WriteLine($"Month 1 sales: \t\t{monthOne:c}");
            Console.WriteLine($"Month 2 sales: \t\t{monthTwo:c}");
            Console.WriteLine($"Month 3 sales: \t\t{monthThree:c}");
            Console.WriteLine($"Total Quarterly Sales: \t{monthOne + monthTwo + monthThree:c}");
            break;
        case "x":
            cont = false;
            break;
        default:
            Console.WriteLine("Invalid choice, try again");
            break;
    }
}
Console.WriteLine("\nPress an any key to continue.");
Console.ReadKey();
struct Employee
{
    string name;
    int id;
    public Employee(string fname, string lname, int id)
    {
        this.name = $"{fname} {lname}";
        this.id = id;
    }
    public string printInfo() { return $"{name} {id}"; }
}