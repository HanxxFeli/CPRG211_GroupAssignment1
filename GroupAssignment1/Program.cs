using GroupAssignment1;

// Create appliances list
List<Appliance> appliances = ApplianceIO.ReadFromFile();
Refrigerator test = new Refrigerator("123","ABC",43,23,"Black",1234,2,123,222);
appliances.Add(test);
int userOption = 0;


while (userOption != 5)
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
    userOption = Convert.ToInt32(option);
    switch (userOption)
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
            Console.WriteLine("Enter number of appliances:");
            string numOfAppliance = Console.ReadLine();


            break;
        case 5:
            ApplianceIO.WriteFile(appliances);

            break;
    }

}

