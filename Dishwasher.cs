using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    public enum SoundRatingDishwasher { Moderate, Quietest, Quieter, Quiet }
    internal class Dishwasher : Appliance
    {
        //private fields
        private string _feature;
        private string _soundRating;

        //public properties
        public string Feature { get; set; }

        public string SoundRating { get; set; }

        //methods
        public Dishwasher(string itemNumber,string brand,int quantity, double wattage, string color,  double price,  string feature, string soundRating) : base(brand, color, itemNumber, price, quantity, wattage)
        {
            Feature = feature;
            SoundRating = soundRating;
        }

        public override void FormatForFile()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string display = $"{this.ItemNumber} \n" +
                $"{this.Brand} \n" +
                $"{this.Quantity} \n" +
                $"{this.Wattage}\n" +
                $"{this.Color}\n" +
                $"{this.Price}\n" +
                $"{this.Feature} \n" +
                $"{this.SoundRating}";
            return display;
        }

        public override void Checkout()
        {
            if (this.Quantity > 0)
            {
                //available count -= 1;
                Console.WriteLine($"Appliance {this.ItemNumber} has been checked out.");
            }
            else
            {
                Console.WriteLine($"The appliance is not available to be checked out.");
            }
        }    
    }
}
