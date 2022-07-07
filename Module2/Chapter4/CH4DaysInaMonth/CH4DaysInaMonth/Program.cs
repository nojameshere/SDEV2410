Console.WriteLine("Chapter 4 Days in a Month by James Sales");
Console.Write("\nEnter the number of a month: ");
int month = int.Parse(Console.ReadLine());
switch(month)
{
    //Case stack for months with 31 days in them
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("That month has 31 days");
        break;
    //Case for february (such a unique month)
    case 2:
        Console.WriteLine("That month has 28 days");
        break;
    //Case stack for months with only 30 days
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("That month has 30 days");
        break;
    //Default statement for 0 or anything over 12 as an 'error statement'
    default:
        Console.WriteLine("That is not a valid month");
        break;
}
Console.WriteLine("\nUsing the keyboard, press any single key to continue");
Console.ReadKey();