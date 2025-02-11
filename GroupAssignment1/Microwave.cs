using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    // enum for room types
    enum roomType { K, W };
    internal class Microwave : Appliance
    {
        // private data 
        private double _capacity;
        private roomType _roomType;

        public double Capacity { get; set; }
        public roomType RoomType { get; set; }
        public string RoomTypeDisplay
        {
            get
            {
                if (RoomType == roomType.W)
                {
                    return "Work Site";
                }
                else return "Kitchen";
            }
        }

        // methods
        public Microwave(string itemNumber, string brand, int quantity, double wattage, string color, double price, double capacity, roomType roomType) :
            base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Capacity = capacity;
            this.RoomType = roomType;
        }

        public override string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price};{Capacity};{RoomType}";
        }

        public override string ToString()
        {
            return $"ItemNumber: {ItemNumber} " +
                $"\nBrand: {Brand}" +
                $"\nQuantity: {Quantity}" +
                $"\nWattage: {Wattage}" +
                $"\nColor: {Color}" +
                $"\nPrice: {Price}" +
                $"\nCapacity: {Capacity}" +
                $"\nRoomTypeDisplay: {RoomTypeDisplay}";
        }
    }
}
