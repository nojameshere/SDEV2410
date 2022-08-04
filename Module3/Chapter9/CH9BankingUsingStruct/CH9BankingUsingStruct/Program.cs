Console.WriteLine("Chapter 9 Banking using Struct by James Sales");
bool cont = true;
Account bankAccount = new Account();
Console.Write("\nWhat is the account ID? ");
bankAccount.id = Console.ReadLine();
Console.Write("Customer's last name? ");
bankAccount.lastName = Console.ReadLine();
Console.Write("What is the balance? $");
bankAccount.balance = double.Parse(Console.ReadLine());
Console.Write("What is the transaction fee? ");
bankAccount.fee = double.Parse(Console.ReadLine());
bankAccount.AccountDetails();

while (cont)
{
    Console.Write("\nWhat do you want to do? (b)balance, (w)withdraw, (d)deposit, or (x)exit? ");
    string response = Console.ReadLine();
    if (response == "w")
    {
        //Withdraw logic
        Console.Write("How much would you like to withdraw? $");
        try
        {
            double withdrawl = double.Parse(Console.ReadLine());
            if (withdrawl <= bankAccount.balance)
            {
                bankAccount.balance = bankAccount.balance - withdrawl - bankAccount.fee;
                Console.WriteLine("Withdrawal successful");
                Console.WriteLine(bankAccount.AccountDetails());
            }
            else { throw new Exception(); }
        }
        catch (FormatException)
        {
            Console.WriteLine("Input string in wrong format.");
        }
        catch (Exception)
        {
            Console.WriteLine("Insufficient funds");
        }
        
    }
    else if (response == "b")
    {
        Console.WriteLine(bankAccount.AccountDetails());
    }
    else if (response == "d")
    {
        //Deposit logic
        Console.Write("How much would you like to deposit? ");
        try
        {
            double deposit = double.Parse(Console.ReadLine());
            bankAccount.balance = bankAccount.balance + deposit - bankAccount.fee;
            Console.WriteLine("Deposit successful");
            Console.WriteLine(bankAccount.AccountDetails());
        }
        catch(FormatException)
        {
            Console.WriteLine("Operation cancelled");
            Console.WriteLine("Input string in wrong format.");
        }
    }
    else if (response == "x")
    {
        cont = false;
    }
}

Console.WriteLine("Press an any key to continue...");
Console.ReadKey();
struct Account
{
    public string id;
    public string lastName;
    public double balance;
    public double fee;
    
    public void Deposit(double cashToDeposit)
    {

    }
    public void Withdraw()
    {

    }
    public string AccountDetails()
    {
        return $"Account {id} for {lastName}, Balance ${balance:N2}, fee ${fee:N2}";
    }
}