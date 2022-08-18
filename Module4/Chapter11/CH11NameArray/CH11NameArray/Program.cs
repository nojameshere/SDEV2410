Console.WriteLine("Chapter 11 Name Array by James Sales\n");

string[] first = new string[4];
string[] last = new string[4];
for(int i = 0; i < 4; i++)
{
    Console.Write("Enter first and last name: ");
    string name = Console.ReadLine();
    string[] temp = name.Split(' ');
    if(temp.Length > 2)
    {
        Console.WriteLine("Too many names entered, rejecting response");
    }
    else
    {
        first[i] = temp[0];
        last[i] = temp[1];
    }
}
Console.WriteLine("\nThese are the names:");
for(int i = 0; i < 4; i++)
{
    Console.WriteLine($"{first[i]} {last[i].PadRight(4)}  Length {first[i].Length + last[i].Length}");
}

Console.WriteLine("\nPress a key to continue");
Console.ReadKey();