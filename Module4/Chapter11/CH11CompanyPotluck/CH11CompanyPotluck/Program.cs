using System.Collections; //This is where ArrayLists are from. 
Console.WriteLine("Chapter 11 Company Potluck by James Sales");

bool cont = true;
var attendees = new ArrayList();

while (cont)
{
    Console.Write("\nWhat do you want to do? (a)Add entry, (p)Print list, (r)Remove entry, (c)Change Entry, or (x)Exit? ");
    string response = Console.ReadLine();
    switch (response)
    {
        case "a":
            //code for Adding an entry to the array list
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();
            Console.Write("Enter Potluck Item: ");
            string item = Console.ReadLine();
            var temp = new Attendee(fname, lname, item);
            attendees.Add(temp); //the .Add method adds this entry at the end of the arraylist
            break;
        case "p":
            //Code to print the list
            Console.WriteLine(value: $"List of {attendees.Count} attendees");
            foreach (Attendee attendee in attendees)
            {
                Console.WriteLine($"{attendee.Display()} is bringing {attendee.foodItem}");
            }
            break;
        case "r":
            //Code for removing and entry
            Console.WriteLine("Remove which person?");
            Console.Write("Enter First Name: ");
            string removeFirst = Console.ReadLine();
            Console.Write("Enter Last Name:");
            string removeLast = Console.ReadLine();
            int index = findAttendee(attendees, removeLast, removeFirst);
            if (index == -1) { Console.WriteLine("Entry not found"); }
            else
            {
                attendees.RemoveAt(index);
                Console.WriteLine("Entry Removed");
            }
            break;
        case "c":
            //Code for changing and entry
            Console.WriteLine("Change item for which person?");
            Console.Write("Enter First Name: ");
            string changeFirst = Console.ReadLine();
            Console.Write("Enter Last Name:");
            string changeLast = Console.ReadLine();
            index = findAttendee(attendees, changeLast, changeFirst);
            if (index == -1) { Console.WriteLine("Entry not found"); }
            else
            {
                
                Console.Write("What is the new item? ");
                Attendee attendee = (Attendee)attendees[index];
                attendee.setFoodItem(Console.ReadLine());
                Console.WriteLine("Entry Changed");
            }
            break;
        case "x":
            cont = false;
            break;
        default:
            Console.WriteLine("That input is not recognized try again");
            break;
    }
}
Console.WriteLine("Press an individual key to continue");
Console.ReadKey();

static int findAttendee(ArrayList attendees, string lName, string fName)
{
    for (int i = 0; i < attendees.Count; i++)
    {
        Attendee attendee = (Attendee)attendees[i];
        if (attendee.getLast() == lName && attendee.getFirst() == fName)
        {
            return i;
        }
    }
    return -1;
}

class Attendee
{
    public string first;
    public string last;
    public string foodItem;
    public Attendee(string first, string last, string foodItem)
    {
        this.first = first;
        this.last = last;
        this.foodItem = foodItem;
    }
    public string Display() { return $"{first} {last}"; }
    public string getFirst() { return first; }
    public string getLast() { return last; }
    public string getFoodItem() { return foodItem; }
    public void setFoodItem(string foodItem) => this.foodItem = foodItem;
}