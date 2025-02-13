using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal static class ModernAppliance
    {
        /// <summary>
        /// Looks for appliance by matching the item numbers and then removes one from the quantity
        /// </summary>
        /// <param name="appliances">A list of Appliance objects where to search the item to be checked out</param>
        public static void CheckOut(List<Appliance> appliances) 
        {
            Console.WriteLine("Enter the item number of an appliance:");
            string number = Console.ReadLine()!;//Input of item number
            bool found = false;
            foreach (Appliance appliance in appliances)
            {
                if (number.Equals(appliance.ItemNumber))//When item number found the checkout process goes through here
                {
                    if (appliance.Quantity > 0)//If there are items to be checked out
                    {
                        appliance.Quantity--;
                        Console.WriteLine($"""Appliance "{appliance.ItemNumber}" has beeen checked out.""");
                        Console.WriteLine();
                    }
                    else//No items to be checked out
                    {
                        Console.WriteLine("The appliance is not available to be checked out\n");
                    }
                    found = true;
                    break;
                }
            }
            if (!found) Console.WriteLine("No appliances found with that item number.\n");//If the item number was not there
        }


        /// <summary>
        /// Searches for appliancesby brand the search is case insesnsitive
        /// </summary>
        /// <param name="appliances">The list to search for appliances with that brand name</param>
        public static void SearchByBrand(List<Appliance> appliances) // To list appliances with the specific brand
        {
            Console.WriteLine("Enter brand to search for:");
            string brandSearch = Console.ReadLine()!.ToLower();//Input the brand name
            bool found = false;
            Console.WriteLine("Matching Appliances:\n ");
            foreach (Appliance appliance in appliances)
            {
                if (appliance.Brand.ToLower() == brandSearch)//Looks at brand name for he appliance and tries to match with input name
                {
                    Console.WriteLine(appliance);
                    found = true;
                }
            }
            if(!found) Console.WriteLine("Appliance with that brand name is not available");//If brand name is entered wrongly
        }


        /// <summary>
        /// Asks and displays refrigerators according to the number of doors needed
        /// </summary>
        /// <param name="appliances">The list where the refrigerators are</param>
        public static void DisplayRefrigerator(List<Appliance> appliances)
        {
            List<Appliance> refrigerators = new List<Appliance>();
            foreach (Appliance appliance in appliances)//This is to sort out refrigerators from other appliances to avoid errors
            {
                if (appliance is Refrigerator)
                {
                    refrigerators.Add(appliance);
                }
            }
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
            string doorInput = Console.ReadLine()!;//Enter number of doors
            Console.WriteLine("Matching refrigerators:\n");
            int intdoorInput = int.Parse(doorInput)!;
            bool found = false;
            foreach (Refrigerator refrigerator in refrigerators) 
            {
                if (intdoorInput == refrigerator.Doors)//Checks if any refrigerator has that number of doors
                {
                    Console.WriteLine($"{refrigerator}");
                    found = true;//To avoid error message
                }
            }
            if(!found) Console.WriteLine("Invalid number of doors.");
        }


        /// <summary>
        /// Asks and displays Vacuums according to the voltage value
        /// </summary>
        /// <param name="appliances">The list where the vacuums are</param>
        public static void DisplayVacuum(List<Appliance> appliances)
        {
            List<Appliance> vacuums = new List<Appliance>();
            foreach (Appliance appliance in appliances)//This is to sort out vacuums from other appliances to avoid errors
            {
                if (appliance is Vacuum)
                {
                    vacuums.Add(appliance);
                }
            }
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high):");
            string voltInput = Console.ReadLine()!;//Enter voltage
            Console.WriteLine("Matching vacuums:\n");
            int intvoltInput = int.Parse(voltInput);
            bool found = false;
            foreach (Vacuum vacuum in vacuums)
            {
                if (intvoltInput == vacuum.BatteryVoltage)//Checks if any vacuums has that voltage value
                {
                    Console.WriteLine($"{vacuum}");
                    found = true;//To avoid error message
                }
            }
            if (!found) Console.WriteLine("Invalid battery voltage value.");
        }


        /// <summary>
        /// Asks and displays microwaves according to the roomtype
        /// </summary>
        /// <param name="appliances">The list where the microwaves are</param>
        public static void DisplayMicrowave(List<Appliance> appliances)
        {
            List<Appliance> microwaves = new List<Appliance>();//This is to sort out microwavess from other appliances to avoid errors
            foreach (Appliance appliance in appliances)
            {
                if (appliance is Microwave)
                {
                    microwaves.Add(appliance);
                }
            }
            Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
            string roomTypeInput = Console.ReadLine()!;//Enter Roomtype
            Console.WriteLine("Matching microwaves:\n");
            bool found = false;
            roomType roomTypeInputEnum=roomType.NO;//Dummy Enum to avoid any errors

            if (roomTypeInput.Equals("K"))//This is for conversion of the string to enum
            {
                roomTypeInputEnum = roomType.K;
            }
            else if (roomTypeInput.Equals("W"))
            {
                roomTypeInputEnum = roomType.W;
            }


                foreach (Microwave microwave in microwaves)
                {
                    if (roomTypeInputEnum == microwave.RoomType)//Checks if any microwave is for that room type
                    {
                        Console.WriteLine($"{microwave}");
                        found = true;//To avoid error message
                    }
                }
            if (!found) Console.WriteLine("Invalid microwave room.");//If roomtype is wrong
        }


        /// <summary>
        /// Asks and displays dishwasher according to the soun rating
        /// </summary>
        /// <param name="appliances">The list where the dishwahers are</param>
        public static void DisplayDishwasher(List<Appliance> appliances)//To display dishwasher
        {
            List<Appliance> dishwashers = new List<Appliance>();
            foreach (Appliance appliance in appliances)//This is to sort out dishwashers from other appliances to avoid errors
            {
                if (appliance is Dishwasher)
                {
                    dishwashers.Add(appliance);
                }
            }
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
            string soundTypeInput = Console.ReadLine()!;
            Console.WriteLine("Matching dishwashers:\n");
            bool found = false;
            soundRating soundTypeInputEnum= soundRating.NO;//Dummy Enum to avoid any errors

            if (soundTypeInput.Equals("Qt"))//This is for conversion of the string to enum
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
            else if (soundTypeInput.Equals("M"))
            {
                soundTypeInputEnum = soundRating.M;
            }

            foreach (Dishwasher dishwasher in dishwashers)
            {
                if (soundTypeInputEnum == dishwasher.SoundRating)//Checks if dishwasher has that sound rating
                {
                    Console.WriteLine($"{dishwasher}\n");
                    found = true;//To avoid error message
                }
            }
            if (!found) Console.WriteLine("Invalid microwave room.");//If roomtype is wrong
        }


        /// <summary>
        /// To Search for the appliances by brand
        /// </summary>
        /// <param name="appliances">List where the appliances are</param>
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

            switch (applianceOption)//Calls a display appliance type according to the chosen value
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


        /// <summary>
        /// Asks for a number and randomly displays that number of appliances randomly
        /// </summary>
        /// <param name="appliances">Where the appliances are</param>
        public static void RandomAppliance(List<Appliance> appliances)
        {
            // ask for number of appliance(s)
            Console.WriteLine("Enter number of appliances:");
            int NumberOfAppliances = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine("Random appliances:\n");

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
