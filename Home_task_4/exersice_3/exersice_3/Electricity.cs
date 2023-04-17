using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exersice_3
{
    public class Electricity
    {
        public List<Quarter> Quarters { get; set; }
        public decimal PricePerKw { get; set; }

        public Electricity()
        {
            Quarters = new List<Quarter>();
        }

        public void ReadDataFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            int numberOfApartments = int.Parse(lines[0].Split(' ')[0]);
            int quarterNumber = int.Parse(lines[0].Split(' ')[1]);
            List<Apartment> apartments = new List<Apartment>();
            for (int i = 1; i <= numberOfApartments; i++)
            {
                string[] apartmentData = lines[i].Split('\t');
                Apartment apartment = new Apartment
                {
                    Number = int.Parse(apartmentData[0]),
                    Address = apartmentData[1],
                    OwnerLastName = apartmentData[2],
                    StartMeterReading = int.Parse(apartmentData[3]),
                    EndMeterReading = int.Parse(apartmentData[4]),
                    MeterReadingDate = DateTime.ParseExact(apartmentData[5], "dd.MM.yy", CultureInfo.InvariantCulture),
                };
                apartments.Add(apartment);
            }
            Quarter quarter = new Quarter
            {
                Number = quarterNumber,
                Apartments = apartments
            };
            Quarters.Add(quarter);
        }

        /*public string GetReport()
        {
            StringBuilder report = new StringBuilder();
            foreach (Quarter quarter in Quarters)
            {
                report.AppendLine($"Quarter {quarter.Number}");
                report.AppendLine("----------------------------------------------------");
                report.AppendLine("| Apartment |    Owner Last Name   |" +
                    $" Consumption |   Cost    |  Days Since Last Reading |");
                foreach (Apartment apartment in quarter.Apartments)
                {
                    int consumption = apartment.EndMeterReading - apartment.StartMeterReading;
                    decimal cost = consumption * PricePerKw;
                    int daysSinceLastReading = (DateTime.Today - apartment.MeterReadingDate).Days;
                    report.AppendLine($"| {apartment.Number,-10} | {apartment.OwnerLastName,-20}" +
                        $" | {consumption,-11} | {cost,-8:F2} | {daysSinceLastReading,-24} |");
                }
                report.AppendLine("----------------------------------------------------");
                decimal totalConsumption = quarter.Apartments.Sum(a => a.EndMeterReading - a.StartMeterReading);
                decimal totalCost = totalConsumption * PricePerKw;
                int daysSinceLastReadingForQuarter = quarter.Apartments.Select(a => (DateTime.Today - a.MeterReadingDate).Days).Max();
                report.AppendLine($"Total consumption: {totalConsumption:F2}");
                report.AppendLine($"Total cost: {totalCost:F2}");
                report.AppendLine($"Days since last reading: {daysSinceLastReadingForQuarter}");
            }
            return report.ToString();
        }*/

        public string GetOwnerWithLargestDebt()
        {
            string ownerSurname = "";
            decimal largestDebt = 0;
            foreach (Quarter quarter in Quarters)
            {
                foreach (Apartment apartment in quarter.Apartments)
                {
                    decimal debt = (apartment.EndMeterReading - apartment.StartMeterReading) * PricePerKw;
                    if (debt > largestDebt)
                    {
                        largestDebt = debt;
                        ownerSurname = apartment.OwnerLastName;
                    }
                }
            }
            return ownerSurname;
        }

        public List<int> GetApartmentsWithNoElectricityUsage()
        {
            List<int> apartmentsWithNoUsage = new List<int>();
            foreach (Quarter quarter in Quarters)
            {
                foreach (Apartment apartment in quarter.Apartments)
                {
                    int consumption = apartment.EndMeterReading - apartment.StartMeterReading;
                    if (consumption == 0)
                    {
                        apartmentsWithNoUsage.Add(apartment.Number);
                    }
                }
            }
            return apartmentsWithNoUsage;
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            foreach (Quarter quarter in Quarters)
            {
                report.AppendLine($"Quarter {quarter.Number}");
                report.AppendLine("----------------------------------------------------");
                report.AppendLine("| Apartment |    Owner Last Name   |" +
                    $" Consumption |   Cost    |  Days Since Last Reading |");
                foreach (Apartment apartment in quarter.Apartments)
                {
                    int consumption = apartment.EndMeterReading - apartment.StartMeterReading;
                    decimal cost = consumption * PricePerKw;
                    int daysSinceLastReading = (DateTime.Today - apartment.MeterReadingDate).Days;
                    report.AppendLine($"| {apartment.Number,-10} | {apartment.OwnerLastName,-20}" +
                        $" | {consumption,-11} | {cost,-8:F2} | {daysSinceLastReading,-24} |");
                }
                report.AppendLine("----------------------------------------------------");
                decimal totalConsumption = quarter.Apartments.Sum(a => a.EndMeterReading - a.StartMeterReading);
                decimal totalCost = totalConsumption * PricePerKw;
                int daysSinceLastReadingForQuarter = quarter.Apartments.Select(a => (DateTime.Today - a.MeterReadingDate).Days).Max();
                report.AppendLine($"Total consumption: {totalConsumption:F2}");
                report.AppendLine($"Total cost: {totalCost:F2}");
                report.AppendLine($"Days since last reading: {daysSinceLastReadingForQuarter}");
            }
            return report.ToString();
        }
    }
}