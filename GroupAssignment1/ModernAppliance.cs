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
                        Console.WriteLine($"Appliance {appliance.ItemNumber} has beeen checked out.");//WHere it checks out
                    }
                    else
                    {
                        Console.WriteLine("The appliance is not available to be checked out");//Quantity is not available
                    }
                    found = true;
                    break;
                }
            }
            if (!found) Console.WriteLine("No appliances found with that item number.");//If the item number was not there
        }

        public static void SearchByBrand(List<Appliance> appliances) // To list appliances with the specific brand
        {
            Console.WriteLine("Enter brand to search for:");
            string brandSearch = Console.ReadLine().ToLower();
            bool found = false;

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

        public static void
    }//class
}    
