Console.WriteLine("Chapter 8 Reference and Value Parameters by James Sales\n");

double thisTemp = 211;

Console.WriteLine($"\nOriginal value of thisTemp = {thisTemp}");
Console.WriteLine($"Original value of outTemp is unassigned");

Console.WriteLine($"\nCalling valTemps with valuable variable, this temp = {thisTemp}");
valTemps(thisTemp);
Console.WriteLine($"Return from valTemps, thisTemp = {thisTemp}");

Console.WriteLine($"\nCalling refTemps with ref variable, thisTemp = {thisTemp}");
refTemps(ref thisTemp);
Console.WriteLine($"Return from refTemps, thisTemp = {thisTemp}");

Console.WriteLine("\nCalling outTemps with unassigned variable");
outTemps(out double outTemp);
Console.WriteLine($"Return from outTemps, outTemp = {outTemp}");

void refTemps(ref double refTemp)
{
    Console.WriteLine($"entering refTemp, ref variable = {refTemp}");
    refTemp = (refTemp - 32) * (5.0 / 9.0);
    Console.WriteLine($"leaving refTemp, ref variable = {refTemp}");
}

void outTemps(out double outTemp)
{
    Console.WriteLine("Entering outTemps with variable unassigned");
    outTemp = 98.6;
    outTemp = (outTemp - 32) * (5.0 / 9.0);
    Console.WriteLine($"leaving outTemps, out variable = {outTemp}");
}

void valTemps(double thisTemp)
{
    Console.WriteLine($"entering valtemps, value variable = {thisTemp}");
    thisTemp = (thisTemp - 32) * (5.0 / 9.0);
    Console.WriteLine($"leaving valtemps, value variable = {thisTemp}");
}

Console.WriteLine("\nPress any key to proceed. . .");
Console.ReadKey();