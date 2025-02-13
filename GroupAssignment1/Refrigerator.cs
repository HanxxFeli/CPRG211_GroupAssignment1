using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal class Refrigerator:Appliance
    {
        private int _doors, _height, _width;

        public int Doors { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Refrigerator(string itemNumber, string brand, int quantity, double wattage, string color, double price, int doors, int height, int width) :
            base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Doors = doors;
            this.Height = height;
            this.Width = width;
        }
        public override string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Doors};{Height};{Width}";
        }

        public override string ToString()
        {
            string doors = null;
            switch (this.Doors)
            {
                case 2:
                    doors = "double door";
                    break;
                case 3:
                    doors = "three doors";
                    break;
                case 4:
                    doors = "four doors";
                    break;
            }
            return $"ItemNumber: {ItemNumber}\n" +
                $"Brand: {Brand}\n" +
                $"Quantitiy: {Quantity}\n" +
                $"Wattage: {Wattage}\n" +
                $"Color: {Color}\n" +
                $"Price: {Price}\n" +
                $"Doors: {doors}\n" +
                $"Height: {Height}\n" +
                $"Width: {Width}\n";
        }
    }
}
