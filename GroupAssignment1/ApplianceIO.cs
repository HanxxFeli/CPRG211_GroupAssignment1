using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal static class ApplianceIO
    {
        // File path where appliance data is stored
        private const string PATH = @"..\..\..\res\appliances.txt";
        // Separator used in the file to split data fields
        private const char sep = ';';

        /// <summary>
        /// Reads appliance data from a file and returns a list of Appliance objects.
        /// </summary>
        /// <returns>List of Appliance objects</returns>
        public static List<Appliance> ReadFromFile()
        {
            string line;
            string[] fields;
            StreamReader streamReader = new StreamReader(PATH);
            List<Appliance> appliances = new List<Appliance>();
            Appliance appliance;

            // Read the file line by line until the end
            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine(); // Read a line from the file
                fields = line.Split(sep); // Split the line into fields using the separator
                appliance = null;

                // Determine appliance type based on the first digit of the item number
                switch (fields[0][0].ToString())
                {
                    case "1": // Refrigerator(Item Number, Brand, Quantity, Wattage, Color, Price, Number of Doors, Height, Width)
                        appliance = new Refrigerator(fields[0], fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), int.Parse(fields[6]), int.Parse(fields[7]), int.Parse(fields[8]));
                        appliances.Add(appliance);
                        break;
                        
                    case "2": // Vacuum(Item Number, Brand, Quantity, Wattage, Color, Price, Grade, Battery Voltage)
                        appliance = new Vacuum(fields[0], fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), fields[6], int.Parse(fields[7]));
                        appliances.Add(appliance);

                        // Determine voltage level based on the parsed integer value
                        int voltage = int.Parse(fields[7]);
                        voltageEnum voltageAmount;
                        if (voltage == 18)
                        {
                            voltageAmount = voltageEnum.Low;
                        }
                        else voltageAmount = voltageEnum.High;
                        break;
                        
                    case "3": // Microwave(Item Number, Brand, Quantity, Wattage, Color, Price, Capacity, Room Type)
                        string enumField = fields[7];
                        roomType roomTypeValue;

                        if (enumField[0] == 'K')
                        {
                            roomTypeValue = roomType.K;
                        }
                        else roomTypeValue = roomType.W;

                        appliance = new Microwave(fields[0], fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), double.Parse(fields[6]), roomTypeValue);
                        appliances.Add(appliance);
                        break;
                        
                    case "4" or "5": // Dishwasher(Item Number, Brand, Quantity, Wattage, Color, Price, Feature, Sound Rating)
                        string dishWasherEnum = fields[7];
                        soundRating soundTypeValue;

                        // Determine sound rating based on the string value
                        if (dishWasherEnum.Equals("Qt"))
                        {
                             soundTypeValue= soundRating.Qt;
                        }
                        else if (dishWasherEnum.Equals("Qr"))
                        {
                            soundTypeValue = soundRating.Qr;
                        }
                        else if (dishWasherEnum.Equals("Qu"))
                        {
                            soundTypeValue = soundRating.Qu;
                        }
                        else
                        {
                            soundTypeValue = soundRating.M;
                        }
                        appliance = new Dishwasher(fields[0], fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), fields[6], soundTypeValue);
                        appliances.Add(appliance);
                        break;
                }  
            }
            streamReader.Close();
            return appliances; // Return the list of appliances
        }

        /// <summary>
        /// Writes a list of Appliance objects to a file.
        /// </summary>
        /// <param name="appliances">List of appliances to be written</param>
        public static void WriteFile(List<Appliance> appliances)
        {
            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter(PATH);

            // Iterate over the appliances list and write each appliance to the file
            foreach (Appliance appliance in appliances)
            {
                string line = appliance.FormatForFile(); // Convert appliance to file format
                
                objWriter.WriteLine(line);
            }
            objWriter.Close();
        }
        
    }
}
