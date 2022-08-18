using System.Collections;
Console.WriteLine("Chapter 11 Clean User Responses by James Sales\n");

bool cont = true;
var customers = new ArrayList();
while (cont)
{
    int ID;
    string first;
    string last;
    Console.Write("Enter Customer ID: ");
    try
    {
        ID = int.Parse(Console.ReadLine());
    }
    catch (FormatException) 
    {
        Console.WriteLine("Invalid input, setting ID to 0");
        ID = 0;
    }
    Console.Write("Enter first and last name: ");
    string name = Console.ReadLine();
    string[] temp = name.Split(' ');
    if (temp.Length > 2)
    {
        Console.WriteLine("Too many names entered, rejecting response");
    }
    else
    {
        first = temp[0];
        last = temp[1];
        Customer customer = new Customer(first, last, ID);
        customers.Add(customer);
        //Clean string here
        Console.Write("Do you have another customer to enter? y/n ");
        string contResponse = Console.ReadLine();
        char[] trimYN = { ' ', 'e', 's', 'o' };
        contResponse = contResponse.ToLower().Trim(trimYN);
        if (contResponse == "n") { cont = false; }
    }
    
}
foreach (Customer customer in customers)
{
    Console.WriteLine(customer.Display());
}
Console.WriteLine("\nPress a key to cont.");
Console.ReadKey();



struct Customer
{
    string first;
    string last;
    int ID;
    public Customer(string first, string last, int ID)
    {
        this.first = first;
        this.last = last;
        this.ID = ID;
    }
    public string Display()
    {
        return $"{ID} {first} {last}";
    }
}