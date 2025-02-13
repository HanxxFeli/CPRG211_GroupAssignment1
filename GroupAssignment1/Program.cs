using GroupAssignment1;
/*
 * Assignment:Classes and Inherirtance
 * Authors: Kunj, Hans, Enzo And Aether
 * Summary: Creating a project which reads and stores data of different appliances,
 *          Sorts and Filters Data by brand or by appliance type
 *          Randomly displays an assigned number of appliances
 *          Checks out appliances
 */
// Create appliances list
List<Appliance> appliances = ApplianceIO.ReadFromFile();//Creating list from the txt file
int userOption = 0;


while (userOption != 5)//Looping menu until user chooses save and exit (option 5)
{
    Console.WriteLine("Welcome to Modern Appliances!" +
    "\nHow May We Assist You?" +
    "\n1 – Check out appliance" +
    "\n2 – Find appliances by brand" +
    "\n3 – Display appliances by type" +
    "\n4 – Produce random appliance list" +
    "\n5 – Save & exit\n");

    Console.WriteLine("Enter option:");
    string option = Console.ReadLine();
    Console.WriteLine("");
    userOption = Convert.ToInt32(option);
    switch (userOption)//Calls appropriate method from the ModernAppliance and ApplianceIO classes in order to perform required tasks
    {
        case 1:
            ModernAppliance.CheckOut(appliances);
            break;
        case 2:
            ModernAppliance.SearchByBrand(appliances);
            break;
        case 3:
            ModernAppliance.SearchByType(appliances);
            break;
        case 4:
            ModernAppliance.RandomAppliance(appliances);

            break;
        case 5:
            ApplianceIO.WriteFile(appliances);

            break;
    }

}

