Console.WriteLine("Chapter 10 Monthly Sales Using 2D Array by James Sales\n");
bool cont = true;
//4 people
//3 months of sales
//array to hold ID and Names
//2D array to hold sales amounts for 3 months for the reps
//first array parallel to the sales array.
//(index 0 of people array will have index 0 of the sales array)
//ask for (s)sales for staff (totals for the 3 months), (m) monthly sales total(total sales for each month)
//(x) to exit
string[,] people =
{
    {"569", "James Sales"},
    {"883", "Josh Beitler"},
    {"138", "Clint Betts"},
    {"429", "Melody Westmoreland" }
};
double[,] sales =
{
    {45.8, 32.6, 99.5 },
    {65.7, 11.4, 0.18 },
    {21.8, 36.6, 11.4 },
    {44.6, 10.9, 59.4 }
};

Console.WriteLine($"{people[0, 0]} {people[0, 1]}: \t\t{sales[0, 0]:c}\t\t{sales[0, 1]:c}\t\t{sales[0,2]:c}");
Console.WriteLine($"{people[1, 0]} {people[1, 1]}: \t\t{sales[1, 0]:c}\t\t{sales[1, 1]:c}\t\t{sales[1, 2]:c}");
Console.WriteLine($"{people[2, 0]} {people[2, 1]}: \t\t{sales[2, 0]:c}\t\t{sales[2, 1]:c}\t\t{sales[2, 2]:c}");
Console.WriteLine($"{people[3, 0]} {people[3, 1]}: \t{sales[3, 0]:c}\t\t{sales[3, 1]:c}\t\t{sales[3, 2]:c}");

while (cont)
{
    Console.Write("\nPrint (s)Sales totals for staff, (m)Monthly sales totals, (x)Exit: ");
    string response = Console.ReadLine();
    switch (response)
    {
        case "s":
            //logic for sales
            Console.WriteLine($"{people[0, 0]} {people[0, 1]}: \t\t{sales[0, 0] + sales[0, 1] + sales[0, 2]:c}");
            Console.WriteLine($"{people[1, 0]} {people[1, 1]}: \t\t{sales[1, 0] + sales[1, 1] + sales[1, 2]:c}");
            Console.WriteLine($"{people[2, 0]} {people[2, 1]}: \t\t{sales[2, 0] + sales[2, 1] + sales[2, 2]:c}");
            Console.WriteLine($"{people[3, 0]} {people[3, 1]}: \t{sales[3, 0] + sales[3, 1] + sales[3, 2]:c}");
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






