Console.WriteLine("Chapter 9 Adding Colors with Enum by James Sales\n");

Console.WriteLine("Which colors do you want to add together?");
Console.WriteLine("(r) Red, (g) Green, or (b) Blue");
Console.Write("First color: ");

Colors firstColor = valueParse(Console.ReadLine(), Colors.red);
Console.Write("Second color: ");
Colors secondColor = valueParse(Console.ReadLine(), Colors.green);


//Casting
Colors mixedColor = (Colors)((int)firstColor + (int)secondColor);
Console.WriteLine($"Casting: Result of mixing {firstColor.ToString()} and {secondColor.ToString()} is {mixedColor.ToString()}");
Colors valueParse(string value, Colors defaultValue)
{
    switch (value)
    {
        case "r":
            return Colors.red;
        case "g":
            return Colors.green;
        case "b":
            return Colors.blue;
        default:
            return defaultValue;
    }
}

//Looping
mixedColor = firstColor;
for (int i = 0; i < (int)secondColor; i++)
{
    mixedColor++;
}
Console.WriteLine($"Looping: Result of mixing {firstColor.ToString()} and {secondColor.ToString()} is {mixedColor.ToString()}");

Console.WriteLine("\nPress any key to continue");
Console.ReadKey();


enum Colors
{
    red = 1,
    green = 2,
    yellow = 3,
    blue = 4,
    pink = 5,
    cyan = 6
}
