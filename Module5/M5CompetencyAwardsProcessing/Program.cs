using System.Collections;
Console.WriteLine("Module 5 Competency Exercise, Awards Processing by James Sales");

ArrayList people = new ArrayList();
people.Add(new Customer("James", "Sales", "a49323", 1));
people.Add(new Customer("Josh", "Beitler", "MSPAINTLUVER", 2));
people.Add(new SalesRep("Clint", "Betts", "sr397", 3, 666));
people.Add(new SalesRep("Mork", "Zuckerbjork", "ROBOT", 6, 298));

for (int i = 1; i < 4; i++)
{
    Console.WriteLine($"\nMonth {i}");
    foreach(Person person in people)
    {
        Console.WriteLine(person.ToString());
        person.addSales();
        person.calcBonus(i);
    }
}

Console.WriteLine("\nYou've reached a locked door, try one of your many keys");
Console.ReadKey();

interface Bonus
{
    public void calcBonus(int month);
}

abstract class Person : Bonus
{
    string first, last, ID;
    protected double newSales;
    protected double totalSales = 0;
    public Person(string first, string last, string ID)
    {
        this.first = first;
        this.last = last;
        this.ID = ID;
    }
    public override string ToString()
    {
        return $"{ID} {first} {last}";
    }
    public void addSales()
    {
        Console.Write("Add sales: $");
        newSales = double.Parse(Console.ReadLine());
        totalSales += newSales;
        Console.WriteLine($"New sales total: {totalSales:c}");
    }
    public abstract void calcBonus(int month);
}

class Customer : Person
{
    int birthMonth;
    public Customer(string first, string last, string ID, int birthMonth)
        : base (first, last, ID)
    {
        this.birthMonth = birthMonth;
    }
    public override string ToString()
    {
        return $"Customer {base.ToString()}, birth month {birthMonth}, sales {totalSales:c}";
    }
    public override void calcBonus(int month)
    {
        if (month == birthMonth)
        {
            Console.WriteLine($"Birthday Bonus Cash Back: {newSales / 10:c}");
        }
        else
        {
            Console.WriteLine("Not customer's birthday month, no cashback");
                }
    }
}

class SalesRep : Person
{
    double comissionRate;
    double quota;
    public SalesRep(string first, string last, string ID, double comissionRate, double quota)
        : base (first, last, ID)
    {
        this.comissionRate = comissionRate;
        this.quota = quota;
    }
    public override string ToString()
    {
        return $"Sales Rep {base.ToString()}, comission rate {comissionRate}%, sales {totalSales:c}, quota {quota:c}";
    }
    public override void calcBonus(int month)
    {
        //needs to calc comission and return quota bonus.
        double comission = (comissionRate / 100) * newSales;
        Console.WriteLine($"Sales Rep comission: {comission:c}");
        if(quota * month < totalSales)
        {
            Console.WriteLine("Bonus for making quota: $500");
        }
        else
        {
            Console.WriteLine("Quota not met, no bonus awarded");
        }
    }
}