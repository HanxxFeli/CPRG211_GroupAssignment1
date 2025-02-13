using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal static class ModernAppliance
    {
        public static void CheckOut(List<Appliance> appliances)// In order to checkout any appliance according to their item number 
        {
            Console.WriteLine("Enter the item number of an appliance:");
            string number = Console.ReadLine()!;
            bool found = false;
            foreach (Appliance appliance in appliances)
            {
                if (number.Equals(appliance.ItemNumber))
                {
                    if (appliance.Quantity > 0)
                    {
                        appliance.Quantity--;
                        Console.WriteLine($"""Appliance "{appliance.ItemNumber}" has beeen checked out.""");//WHere it checks out
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("The appliance is not available to be checked out\n");//Quantity is not available
                    }
                    found = true;
                    break;
                }
            }
            if (!found) Console.WriteLine("No appliances found with that item number.\n");//If the item number was not there
        }

        public static void SearchByBrand(List<Appliance> appliances) // To list appliances with the specific brand
        {
            Console.WriteLine("Enter brand to search for:");
            string brandSearch = Console.ReadLine().ToLower();
            bool found = false;
            Console.WriteLine("Matching Appliances: ");
            foreach (Appliance appliance in appliances)
            {
                if (appliance.Brand.ToLower() == brandSearch)
                {
                    Console.WriteLine(appliance);
                    Console.WriteLine(); // empty space for formatting purposes
                    found = true;
                }
            }
            if(!found) Console.WriteLine("Appliance with that brand name is not available");//If brand name is entered wrongly
        }

        public static void DisplayRefrigerator(List<Appliance> appliances)//To display refrigerators
        {
            List<Appliance> refrigerators = new List<Appliance>();
            foreach (Appliance appliance in appliances)
            {
                if (appliance is Refrigerator)
                {
                    refrigerators.Add(appliance);
                }
            }
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
            string doorInput = Console.ReadLine()!;//Enter number of doors
            int intdoorInput = int.Parse(doorInput)!;
            bool found = false;
            foreach (Refrigerator refrigerator in refrigerators) 
            {
                if (intdoorInput == refrigerator.Doors)
                {
                    Console.WriteLine($"{refrigerator}");
                    found = true;//To avoid error message
                }
            }
            if(!found) Console.WriteLine("Invalid number of doors.");
        }

        public static void DisplayVacuum(List<Appliance> appliances)//To display vacuums
        {
            List<Appliance> vacuums = new List<Appliance>();
            foreach (Appliance appliance in appliances)
            {
                if (appliance is Vacuum)
                {
                    vacuums.Add(appliance);
                }
            }
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high):");
            string voltInput = Console.ReadLine()!;//Enter voltage
            int intvoltInput = int.Parse(voltInput);
            bool found = false;
            foreach (Vacuum vacuum in vacuums)
            {
                if (intvoltInput == vacuum.BatteryVoltage)
                {
                    Console.WriteLine($"{vacuum}");
                    found = true;//To avoid error message
                }
            }
            if (!found) Console.WriteLine("Invalid battery voltage value.");
        }

        public static void DisplayMicrowave(List<Appliance> appliances)//To display microwavess
        {
            List<Appliance> microwaves = new List<Appliance>();
            foreach (Appliance appliance in appliances)
            {
                if (appliance is Microwave)
                {
                    microwaves.Add(appliance);
                }
            }
            Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
            string roomTypeInput = Console.ReadLine()!;//Enter Roomtype
            bool found = false;
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
                    Console.WriteLine($"{microwave}");
                    found = true;//To avoid error message
                }
            }
            if (!found) Console.WriteLine("Invalid microwave room.");//If roomtype is wrong
        }

        public static void DisplayDishwasher(List<Appliance> appliances)//To display dishwasher
        {
            List<Appliance> dishwashers = new List<Appliance>();
            foreach (Appliance appliance in appliances)
            {
                if (appliance is Dishwasher)
                {
                    dishwashers.Add(appliance);
                }
            }
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
            string soundTypeInput = Console.ReadLine()!;
            bool found = false;
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
                    found = true;//To avoid error message
                }
            }
            if (!found) Console.WriteLine("Invalid microwave room.");//If roomtype is wrong
        }

        public static void SearchByType(List<Appliance> appliances) 
        {
            // display appliance types 
            Console.WriteLine("Appliance Types" +
                "\n1 – Refrigerators" +
                "\n2 – Vacuums" +
                "\n3 – Microwaves" +
                "\n4 – Dishwashers\n");

            Console.WriteLine("Enter type of appliance:");
            string applianceOption = Console.ReadLine()!;

            switch (applianceOption)
            {
                case "1":
                    ModernAppliance.DisplayRefrigerator(appliances);
                    break;
                case "2":
                    ModernAppliance.DisplayVacuum(appliances);
                    break;
                case "3":
                    ModernAppliance.DisplayMicrowave(appliances);
                    break;
                case "4":
                    ModernAppliance.DisplayDishwasher(appliances);
                    break;
                default:
                    Console.WriteLine("Invalid Number");//If wrong number is input
                    break;
            }
        }

        public static void RandomAppliance(List<Appliance> appliances)
        {
            // ask for number of appliance(s)
            Console.WriteLine("Enter number of appliances:");
            int NumberOfAppliances = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine("");

            //randomizer
            Random randomAppliance = new Random();
            for (int i = 0; i < NumberOfAppliances; i++)
            {
                int rnd = randomAppliance.Next(NumberOfAppliances);
             
                Console.WriteLine($"{appliances[rnd]}\n");
             
            }
       
        }



    }//class
}    
