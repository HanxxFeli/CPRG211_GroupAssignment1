using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    public enum voltageEnum { Low, High}
    internal class Vacuum : Appliance
    {
        private int _batteryVoltage;
        private string _grade;

        public int BatteryVoltage
        {
            get { return _batteryVoltage; }
            set { _batteryVoltage = value >= 0 ? value : 0; }
        }

        public voltageEnum voltageValue { get; set; }
        public string BatteryVoltageDisplay
        {
            get
            {
                if(voltageValue == voltageEnum.Low)
                {
                    return "Low";
                }
                else
                {
                    return "High";
                }
            }
        } 
        public string Grade
        {
            get; set;
        }

        public Vacuum(string itemNumber, string brand, int quantity, double wattage, string color, double price, string grade, int batteryVoltage) :
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
                   $"BatteryVoltage:{BatteryVoltageDisplay}\n"
                ;
        }
    }
}
