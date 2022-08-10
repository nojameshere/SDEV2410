string[] getNames()
{
    Console.Write("How many names ? ");
    int size = int.Parse(Console.ReadLine());
    string[] names = new string[];
    foreach (int k = 1; k <= size; k++)
   {
        Console.Write("Enter new name: ");
        names[k] = Console.ReadKey();
    }
return names;
}
