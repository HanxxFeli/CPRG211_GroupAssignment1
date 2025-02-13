using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal static class ApplianceIO
    {
        private const string PATH = @"..\..\..\res\appliances.txt";
        private const char sep = ';';

        public static List<Appliance> ReadFromFile()
        {
            string line;
            string[] fields;
            StreamReader streamReader = new StreamReader(PATH);
            List<Appliance> appliances = new List<Appliance>();
            Appliance appliance;
            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
                fields = line.Split(sep);
                appliance = null;
                switch (fields[0][0].ToString())
                {
                    case "1":
                        appliance = new Refrigerator(fields[0], fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), int.Parse(fields[6]), int.Parse(fields[7]), int.Parse(fields[8]));
                        appliances.Add(appliance);
                        break;
                    case "2":
                        appliance = new Vacuum(fields[0], fields[1], int.Parse(fields[2]), double.Parse(fields[3]), fields[4], double.Parse(fields[5]), fields[6], int.Parse(fields[7]));
                        appliances.Add(appliance);
                        int voltage = int.Parse(fields[7]);
                        voltageEnum voltageAmount;
                        if (voltage == 18)
                        {
                            voltageAmount = voltageEnum.Low;
                        }
                        else voltageAmount = voltageEnum.High;
                        break;
                    case "3":
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
                    case "4" or "5":
                        string dishWasherEnum = fields[7];
                        soundRating soundTypeValue;

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
            return appliances;
        }

        public static void WriteFile(List<Appliance> appliances)
        {
            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter(PATH);
            foreach (Appliance appliance in appliances)
            {
                string line = appliance.FormatForFile();
                
                objWriter.WriteLine(line);
            }
            objWriter.Close();
        }
        
    }
}
