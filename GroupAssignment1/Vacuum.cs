using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal class Vacuum : Appliance
    {
        private int _batteryVoltage;
        private int _grade;

        public int BatteryVoltage
        {
            get { return _batteryVoltage; }
            set { _batteryVoltage = value >= 0 ? value : 0; }
        }

        public int Grade
        {
            get { return _grade; }
            set { _grade = value >= 0 ? value : 0; }
        }

        public Vacuum(string itemNumber, string brand, int quantity, double wattage, string color, double price, int batteryVoltage, int grade) :
            base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.BatteryVoltage = batteryVoltage;
            this.Grade = grade;
        }


        public override string FormatForFile()
        {
            return $"{ItemNumber},{Brand},{Quantity},{Wattage},{Color},{Grade},{BatteryVoltage}";
        }

        public override string ToString()
        {
            return $"Item Number: {ItemNumber}\n" +
                   $"Brand: {Brand}\n" +
                   $"Wattage: {Quantity}\n" +
                   $"Color: {Color}\n" +
                   $"Price: {Price}\n" +
                   $"Grade: {Grade}\n" +
                   $"Battery Voltage:{BatteryVoltage}\n"
                ;
        }
    }
}
