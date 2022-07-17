Console.WriteLine("Chapter 5 Continental Conversion by James Sales\n");
//Start of MPH conversions
Console.WriteLine("MPH       KPH");
Console.WriteLine("_________________");
for (int MPH = 25; MPH < 101; MPH = MPH + 5)
{
    Console.WriteLine($"{MPH}     {MPH * 1.609:N2}");
}
//Start of USD
Console.WriteLine("\nUS $   Euro");
Console.WriteLine("_________________");
for (int USD = 10; USD < 101; USD = USD + 5)
{
    Console.WriteLine($"{USD}     {USD * .89:N2}");
}
//Start of Temperature
Console.WriteLine("\nF temp   C temp");
Console.WriteLine("_________________");
for (int TEMP = 32; TEMP < 111; TEMP = TEMP + 2)
{
    Console.WriteLine($"{TEMP}     {(TEMP - 32) * .556:N2}");
}

Console.WriteLine("\nPress any key of your choosing to continue");
Console.ReadKey();