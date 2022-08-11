Console.WriteLine("Chapter 11 Sales Quotas by James Sales");

//I don't fucking know anymore. I can't think or focus on this tonight. I had motivation but that was diminished by the grades I recieved on two previous products.



struct Employee
{
    public string first;
    string last;
    public double quota;
    public Employee(string fname, string lname, double quota)
    {
        this.first = fname;
        this.last = lname;
        this.quota = quota;
    }
    public string Display() { return $"{first} {last}"; }
}