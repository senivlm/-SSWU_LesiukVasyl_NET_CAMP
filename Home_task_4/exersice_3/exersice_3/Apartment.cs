using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_3
{
    public class Apartment
    {
        public int Number { get; set; }
        public string Address { get; set; }
        public string OwnerLastName { get; set; }
        public int StartMeterReading { get; set; }
        public int EndMeterReading { get; set; }
        public DateTime MeterReadingDate { get; set; }

        public decimal CalculateElectricityBill(decimal electricityPrice)
        {
            int usedEnergy = EndMeterReading - StartMeterReading;
            return electricityPrice * usedEnergy;
        }

        public int GetDaysSinceLastMeterReading()
        {
            return (DateTime.Today - MeterReadingDate).Days;
        }

        public override string ToString()
        {// виділені параметри форматування слід робити гнучкими для користувача. 
            return $"{Number,-5} {OwnerLastName,-15} {StartMeterReading,-10} {EndMeterReading,-10} {MeterReadingDate:dd.MM.yy}";
        }
    }
}
