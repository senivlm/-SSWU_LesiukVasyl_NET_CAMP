using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_3
{
    public class Quarter
    {
        public int Number { get; set; }
        public List<Apartment> Apartments { get; set; }

        public decimal CalculateTotalElectricityBill(decimal electricityPrice)
        {
            decimal totalBill = 0;
            foreach (Apartment apartment in Apartments)
            {
                totalBill += apartment.CalculateElectricityBill(electricityPrice);
            }
            return totalBill;
        }

        public Apartment FindApartment(int apartmentNumber)
        {
            return Apartments.Find(a => a.Number == apartmentNumber);
        }

        public Apartment FindApartmentWithNoElectricityUsage()
        {
            return Apartments.Find(a => a.StartMeterReading == a.EndMeterReading);
        }

        public string FindOwnerWithLargestDebt(decimal electricityPrice)
        {
            string ownerWithLargestDebt = "";
            decimal largestDebt = 0;
            foreach (Apartment apartment in Apartments)
            {
                decimal debt = apartment.CalculateElectricityBill(electricityPrice) - (apartment.EndMeterReading - apartment.StartMeterReading) * electricityPrice;
                if (debt > largestDebt)
                {
                    largestDebt = debt;
                    ownerWithLargestDebt = apartment.OwnerLastName;
                }
            }
            return ownerWithLargestDebt;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{"Номер квартири",-5} {"Власник",-15} {"Поч. показ.",-10} {"Кінц. показ.",-10} {"Дата",-10}");
            foreach (Apartment apartment in Apartments)
            {
                sb.AppendLine(apartment.ToString());
            }
            return sb.ToString();
        }
    }
}
