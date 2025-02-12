using GroupAssignment1;

// Create appliances list
List<Appliance> appliances = ApplianceIO.ReadFromFile();
List<Appliance> refrigerators = new List<Appliance>();
List<Appliance> vacuums = new List<Appliance>();
List<Appliance> microwaves = new List<Appliance>();
List<Appliance> dishwashers = new List<Appliance>();

// add each appliance to their own list
foreach (Appliance appliance in appliances)
{
    if (appliance is Refrigerator)
    {
        refrigerators.Add(appliance);
    }
    else if (appliance is Vacuum)
    {
        vacuums.Add(appliance);
    }
    else if (appliance is Microwave)
    {
        microwaves.Add(appliance);
    }
    else {
        dishwashers.Add(appliance);
    }
}

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
        ModernAppliance.CheckOut(appliances);
        break;
    case 2:
        ModernAppliance.SearchByBrand(appliances);
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

        switch (applianceOption)
        {
            case "1":
                Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
                string doorInput = Console.ReadLine();
                int intdoorInput = int.Parse(doorInput);

                foreach (Refrigerator refrigerator in refrigerators)
                {
                    if (intdoorInput == refrigerator.Doors)
                    {
                        Console.WriteLine($"{refrigerator}\n");
                    }
                }
                break;
            case "2":
                Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high):");
                string voltInput = Console.ReadLine();
                int intvoltInput = int.Parse(voltInput);

                foreach (Vacuum vacuum in vacuums)
                {
                    if (intvoltInput == vacuum.BatteryVoltage)
                    {
                        Console.WriteLine($"{vacuum}\n");
                    }
                }

                break;
            case "3":
                Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
                string roomTypeInput = Console.ReadLine();
                roomType roomTypeInputEnum;

                if (roomTypeInput.Equals("K"))
                {
                    roomTypeInputEnum = roomType.K;
                }
                else roomTypeInputEnum = roomType.W;

                foreach (Microwave microwave in microwaves)
                {
                    if (roomTypeInputEnum == microwave.RoomType)
                    {
                        Console.WriteLine($"{microwave}\n");
                    }
                }
                break;
            case "4":
                Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
                string soundTypeInput = Console.ReadLine();
                soundRating soundTypeInputEnum;

                if (soundTypeInput.Equals("Qt"))
                {
                    soundTypeInputEnum = soundRating.Qt;
                }
                else if (soundTypeInput.Equals("Qr"))
                {
                    soundTypeInputEnum = soundRating.Qr;
                }
                else if (soundTypeInput.Equals("Qu"))
                {
                    soundTypeInputEnum = soundRating.Qu;
                }
                else
                {
                    soundTypeInputEnum = soundRating.M;
                }

                foreach (Dishwasher dishwasher in dishwashers)
                {
                    if (soundTypeInputEnum == dishwasher.SoundRating)
                    {
                        Console.WriteLine($"{dishwasher}\n");
                    }
                }



                break;
        }


        break;
    case 4:
        Console.WriteLine("Enter number of appliances:");
        string numOfAppliance = Console.ReadLine();


        break;
    case 5:


        break;
}

