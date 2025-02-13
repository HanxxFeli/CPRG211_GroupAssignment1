using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    public enum soundRating { Qt, Qr, Qu, M, NO }// enum for sound rating
    internal class Dishwasher : Appliance//Reference of abstract class from which we inherit stuff
    {
        //private fields
        private string _feature;
        private string _soundRating;

        //public properties
        public string Feature { get; set; }

        public soundRating SoundRating { get; set; }

        public string SoundRatingDisplay
        {
            get
            {
                if (SoundRating == soundRating.Qt)
                {
                    return "Quietest";
                }
                else if (SoundRating == soundRating.Qr)
                {
                    return "Quieter";
                }
                else if (SoundRating == soundRating.Qu)
                {
                    return "Quiet";
                }
                else return "Moderate";
            }
        }

        //methods
        public Dishwasher(string itemNumber,string brand,int quantity, double wattage, string color,  double price,  string feature, soundRating soundRating) : base(itemNumber, brand, quantity, wattage, color, price)//Inheriting different attributes from the abtract class
        {
            this.Feature = feature;
            this.SoundRating = soundRating;
        }

        public override string FormatForFile()
        {
          return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Feature};{SoundRating}";
        }

        public override string ToString()
        {
            return $"ItemNumber: {ItemNumber}\n" +
                $"Brand: {Brand}\n" +
                $"Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}\n" +
                $"Color: {Color}\n" +
                $"Price: {Price}\n" +
                $"Feature: {Feature}\n" +
                $"SoundRating: {SoundRatingDisplay}\n";
        }
         
    } 
}
