Fun fruit = new Fun();
fruit.Display();
fruit.price = 55;
fruit.Display();



class Fun
{
    string name;
    public int price;
    public Fun()
    {
        this.name = "banana";
        this.price = 21;
    }
    public void Display()
    {
        Console.WriteLine($"{name} {price}");
    }
}