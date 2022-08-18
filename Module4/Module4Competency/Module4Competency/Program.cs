using System.Collections;
Console.WriteLine("Module 4 Competency Exercise Customer List by James Sales");
//Hard Code 3 Customer Objects
bool cont = true;
var customersArray = new ArrayList();
customersArray.Add(new Customer(123, "James", "Sales"));
customersArray.Add(new Customer(234, "Josh", "Beitler"));
customersArray.Add(new Customer(345, "Elise", "Fernandez"));
//Print hard-coded customers
Console.WriteLine("\nCustomers who were hard-coded");
foreach (Customer customer in customersArray)
{
    Console.WriteLine(customer.Display());
}

while (cont)
{
    Console.Write("\nWhat do you want to do? (a)Add, (d)Delete, (c)Change, (p)Print: ");
    string userResponse = Console.ReadLine();
    int newID;
    string newFirst;
    string newLast;
    int queryID;
    switch (userResponse)
    {
        case "a":
            //code for add
            Console.Write("Enter new customer ID: ");
            try
            {
                newID = int.Parse(Console.ReadLine());
            }
            catch (FormatException) 
            {
                Console.WriteLine("Invalid input, setting ID to 0");
                newID = 0;
            }
            Console.Write("Enter first name: ");
            newFirst = Console.ReadLine();
            Console.Write("Enter last name: ");
            newLast = Console.ReadLine();
            Customer temp = new Customer(newID, newFirst, newLast);
            customersArray.Add(temp);
            break;
        case "d":
            //code for delete
            Console.Write("Enter Customer ID: ");
            try
            {
                queryID = int.Parse(Console.ReadLine());
                int index = findCustomer(customersArray, queryID);
                if (index == -1) { Console.WriteLine("Entry not found"); }
                else
                {
                    customersArray.RemoveAt(index);
                    Console.WriteLine("Entry Removed");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Customer not found");
            }
            
            break;
        case "c":
            //code for change
            Console.Write("Enter Customer ID: ");
            try
            {
                queryID = int.Parse(Console.ReadLine());
                int index = findCustomer(customersArray, queryID);
                if (index == -1) { Console.WriteLine("Entry not found"); }
                else
                {
                    Console.Write("Enter First Name: ");
                    string changeFirst = Console.ReadLine();
                    Console.Write("Enter Last Name: ");
                    string changeLast = Console.ReadLine();
                    Customer customer = (Customer)customersArray[index];
                    customer.setFirst(changeFirst);
                    customer.setLast(changeLast);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Customer not found");
            }
            break;
        case "p":
            //Code for print
            foreach (Customer customer in customersArray)
            {
                Console.WriteLine(customer.Display());
            }
            break;
        default:
            Console.WriteLine("Invalid selection");
            break;
    }
    Console.Write("All done? y/n ");
    string contResponse = Console.ReadLine();
    char[] trimYN = { ' ', 'e', 's', 'o' };
    contResponse = contResponse.ToLower().Trim(trimYN);
    if (contResponse == "y") { cont = false; }
}
Console.WriteLine("Press a key to cont");
Console.ReadKey();

//Helper method for finding specific entry goes here
static int findCustomer(ArrayList customers, int ID)
{
    for (int i = 0; i < customers.Count; i++)
    {
        Customer customer = (Customer)customers[i];
        if (customer.getID() == ID)
        {
            return i;
        }
    }
    return -1;
}

class Customer
{
    int ID;
    string first;
    string last;
    public Customer(int iD, string first, string last)
    {
        ID = iD;
        this.first = first;
        this.last = last;
    }
    public string Display()
    {
        return $"{ID} {first} {last}";
    }
    public int getID() { return ID; }
    public void setFirst(string first)
    {
        this.first = first;
    }
    public void setLast(string last)
    {
        this.last = last;
    }
}