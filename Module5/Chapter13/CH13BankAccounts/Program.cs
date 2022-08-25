using System.Collections;
Console.WriteLine("Chapter 13 Bank Accounts by James Sales");
ArrayList accounts = new ArrayList();

accounts.Add(new Checking(11369, "James", "Sales", 13056, .56));
accounts.Add(new Checking(11830, "Josh", "Beitler", 210598, 13.5));
accounts.Add(new Savings(001, "Tyler", "Smith", 465, 1.6));
accounts.Add(new Savings(003, "Lucifer", "Morningstar", 1450190, 6.66));
accounts.Add(new CreditCard(419190, "Clint", "Betts", 12000, 12100));
accounts.Add(new CreditCard(558310, "Cory", "Coleman", 1.33, 1300));

foreach(Account account in accounts)
{
    Console.WriteLine();
    Console.WriteLine(account.ToString());
    Console.Write("How much would you like to add/pay? ");
    try
    {
        double add = double.Parse(Console.ReadLine());
        account.Credit(add);
    }
    catch (FormatException)
    {
        Console.WriteLine("Input string in incorrect format");
    }
    Console.WriteLine(account.ToString());
    Console.Write("How much would you like to withdraw/charge? ");
    try
    {
        double remove = double.Parse(Console.ReadLine());
        account.Debit(remove);
    }
    catch (FormatException)
    {
        Console.WriteLine("Input string in incorrect format");
    }
}

Console.WriteLine("\nPress an key to continue");
Console.ReadKey();

abstract class Account
{
    int accountNumber;
    string first, last;
    public Account (int accountNumber, string first, string last)
    {
        this.accountNumber = accountNumber;
        this.first = first;
        this.last = last;
    }
    public override string ToString()
    {
        return $"{accountNumber}: {first} {last}";
    }
    public abstract void Credit(double amount);
    public abstract void Debit(double amount);
}

//Class types:Checking account, savings account, credit card
class Checking : Account
{
    double balance; //I feel like this should be in the base class...
    double fee;
    public Checking(int accountNumber, string first, string last, double balance, double fee)
        : base (accountNumber, first, last)
    {
        this.balance = balance;
        this.fee = fee;
    }
    public override void Credit(double amount)
    {
        balance += (amount - fee);
        Console.WriteLine($"Deposit successful, balance {balance:c}");
        //code for adding balance;
    }
    public override void Debit(double amount)
    {
        if (amount <= (balance + fee))
        {
            balance -= (amount - fee);
            Console.WriteLine($"Withdrawl successful, balance {balance:c}");
        }        //code for removing balance;
        else
        {
            Console.WriteLine("Insufficient balance for transaction");
        }
    }
    public override string ToString()
    {
        return $"{base.ToString()}, fee {fee}, balance {balance}";
    }
}

class Savings : Account
{
    double balance;
    double interestRate;
    public Savings(int accountNumber, string first, string last, double balance, double interestRate)
        : base (accountNumber, first, last)
    {
        this.balance = balance;
        this.interestRate = interestRate;
    }
    public override void Credit(double amount)
    {
        balance += ((amount * (interestRate / 100)) + amount);
        Console.WriteLine($"Deposit successful, balance: {balance:c}");
        //code for credit;
    }
    public override void Debit(double amount)
    {
        //code for debit;
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Balance after debit {balance:c}");
        }
        else
        {
            Console.WriteLine("Insufficient balance for transaction");
        }
    }
    public override string ToString()
    {
        return $"{base.ToString()}, interest rate {interestRate}%, balance {balance:c}";
    }
}

class CreditCard : Account
{
    double balance;
    double limit;
    public CreditCard(int accountNumber, string first, string last, double balance, double limit)
        : base(accountNumber, first, last)
    {
        this.balance = balance;
        this.limit = limit;
    }
    public override void Credit(double amount)
    {
        //This make a payment to decrease the balance
        balance -= amount;
        Console.WriteLine($"Payment Successful, Balance after payment {balance:c}");
    }
    public override void Debit(double amount)
    {
        //Charges the card and increases the balance
        if (amount + balance <= limit)
        {
            balance += amount;
            Console.WriteLine($"Charge successful, balance: {balance:c}");
        }
        else
        {
            Console.WriteLine("This purchase will excede your credit limit");
        }
    }
    public override string ToString()
    {
        return $"{base.ToString()}, limit {limit:c}, balance {balance:c}";
    }
}