using GroupAssignment1;


Console.WriteLine("Welcome to Modern Appliances!" +
    "\nHow May We Assist You?" +
    "\n1 – Check out appliance" +
    "\n2 – Find appliances by brand" +
    "\n3 – Display appliances by type" +
    "\n4 – Produce random appliance list" +
    "\n5 – Save & exit\n");

Console.WriteLine("Enter option:");
string option = Console.ReadLine();
int userOption = Convert.ToInt32(option);


switch (userOption)
{
    case 1:
        // appliance can be checked out 

        // appliance not available 

        // appliance does not exist
        break;
    case 2:
        // search for appliance using appliance.brand 

        break;
    case 3:
        // display appliance types 
        Console.WriteLine("Appliance Types" +
            "\n1 – Refrigerators" +
            "\n2 – Vacuums" +
            "\n3 – Microwaves" +
            "\n4 – Dishwashers\n");

        Console.WriteLine("Enter type of appliance:");
        string applianceOption = Console.ReadLine();

        break;
    case 4:
        Console.WriteLine("Enter number of appliances:");
        string numOfAppliance = Console.ReadLine();


        break;
    case 5:


        break;
}
