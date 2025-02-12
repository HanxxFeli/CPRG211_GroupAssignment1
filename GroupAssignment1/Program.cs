using GroupAssignment1;
void CheckOut(List<Appliance> appliances)
{
    Console.WriteLine("Enter the item number of an appliance:");
    string number= Console.ReadLine()!;
    bool found= false;
    foreach(Appliance appliance in appliances)
    {
       if (number.Equals(appliance.ItemNumber))
       {
            if (appliance.Quantity > 0)
            {
                appliance.Quantity--;
                Console.WriteLine($"Appliance {appliance.ItemNumber} has beeen checked out.");
                Console.WriteLine(appliance);
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out");
            }
            found = true;
            break;
       }
    }
    if (!found) Console.WriteLine("No appliances found with that item number.");
}

//Test Checkout
List<Appliance> appliances=ApplianceIO.ReadFromFile();
CheckOut(appliances);


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
