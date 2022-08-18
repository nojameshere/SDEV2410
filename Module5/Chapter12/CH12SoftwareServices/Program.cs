Console.WriteLine("Chapter 12 Software Services by James Sales");

Service[] services = new Service[6];

services[0] = new Web(3319, "Arrowhead", 591, "New", "In Progress", "www.ArguablyTheBestWaterComapny.com/BestWaterEver/", 126);
services[1] = new Desktop(104, "Return to win10", 26, "Maintenance", "Complete", "Windows", "GUI Form");
services[2] = new Web(501, "GreatValue", 666, "Maintenance", "Not Started", "www.Walmart.com/Minimum_Effort.txt", 1);
services[3] = new Mobile(2, "Dating app for Spain (Thinder)", 1978, "New", "Complete", "iPhone");
services[4] = new Desktop(51019290, "FileBomb.exe", 3301, "New", "Not Started", "Linux", "Command Line Screen");
services[5] = new Mobile(19903, "Missile Mode", 4890, "Maintenance", "In Progress", "Android");

foreach (Service service in services)
{
    Console.WriteLine(service.ToString());
}
Console.WriteLine("\nFind specific jobs");
Console.WriteLine("\nStatus types: ip (in progress), ns (not started), c (complete)");
//I want the program to iterate until a valid selecteion has been made. ergo this int.
int errorHandling = 0;
do
{
    Console.Write("Which job status do you want to see? (ip, ns, or c) ");
    string response = Console.ReadLine();
    switch (response)
    {
        case "ip":
            foreach(Service service in services)
            {
                if (service.status == "In Progress")
                {
                    Console.WriteLine(service.ToString());
                }
            }
            //Int incremention for valid selection.
            errorHandling++;
            break;
        case "ns":
            foreach (Service service in services)
            {
                if (service.status == "Not Started")
                {
                    Console.WriteLine(service.ToString());
                }
            }
            errorHandling++;
            break;
        case "c":
            foreach (Service service in services)
            {
                if (service.status == "Complete")
                {
                    Console.WriteLine(service.ToString());
                }
            }
            errorHandling++;
            break;
        default:
            Console.WriteLine("Invalid Selection");
            break;
    }
}
while (errorHandling == 0);

Console.WriteLine("\nPress any key to continue");
Console.ReadKey();

class Service
{
    protected int ID;
    protected string projectName;
    protected int customerID;
    protected string jobType; //Should be "maintenance" or "new"
    public string status; //Needs to be "In progress" "Complete" or "Not started"
    public Service(int ID, string projectName, int customerID, string jobType, string status)
    {
        this.ID = ID;
        this.projectName = projectName;
        this.customerID = customerID;
        this.jobType = jobType;
        this.status = status;
    }
    public override string ToString()
    {
        return $"{jobType} Project {ID}, {projectName} for customer# {customerID}";
    }
}

class Web : Service
{
    string URL;
    int numPages;
    public Web(int ID, string projectName, int customerID, string jobType, string status, string URL, int numPages)
        :base(ID, projectName, customerID, jobType, status)
    {
        this.URL = URL;
        this.numPages = numPages;
    }
    public override string ToString()
    {
        return $"\nWeb: {base.ToString()}, URL: {URL}, {numPages} pages, status: {status}";
    }
}

class Mobile : Service
{
    string device;
    public Mobile(int ID, string projectName, int customerID, string jobType, string status, string device)
        :base(ID, projectName, customerID, jobType, status)
    {
        this.device = device;
    }
    public override string ToString()
    {
        return $"\nMobile: {base.ToString()}, {device} device, status: {status}";
    }
}

class Desktop : Service
{
    string OS;
    string programType;
    public Desktop(int ID, string projectName, int customerID, string jobType, string status, string OS, string programType)
        : base(ID, projectName, customerID, jobType, status)
    {
        this.OS = OS;
        this.programType = programType;
    }
    public override string ToString()
    {
        return $"\nDesktop: {base.ToString()}, {OS} OS with {programType}, status: {status}";
    }
}