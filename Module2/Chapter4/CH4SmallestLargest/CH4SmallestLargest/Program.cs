
Console.WriteLine("Chapter 4 Smallest and Largest by James Sales");
Console.Write("\nEnter first integer: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter second integer: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter third integer: ");
int third = int.Parse(Console.ReadLine());
int average = (first + second + third) / 3;
Console.WriteLine($"Average: {average}");
int largest = 0;
int smallest = 0;

//largest integer conditional
if (first > second)
{
    if (first > third)
    {
        //set first to greatest
        largest = first;
    }
    else
    {
        //set third to greatest
        largest = third;
    }
}
else if (second > third)
{
    //set second to greatest
    largest = second;
}
else
{
    //set third to greatest
    largest = third;
}

//smallest integer conditional
if (first < second)
{
    if (first < third)
    {
        //set first to smallest
        smallest = first;
    }
    else
    {
        //set third to smallest
        smallest = third;
    }
}
else if (second < third)
{
    //set second to smallest
    smallest = second;
}
else
{
    //set third to smallest
    smallest = third;
}
Console.WriteLine($"Largest: {largest}");
Console.WriteLine($"Smallest: {smallest}");
Console.WriteLine("\nPress any key to continue");
Console.ReadKey();
