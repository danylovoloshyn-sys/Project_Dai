using System;
using System.Collections.Generic;

namespace Curs
{
    public class Vehicle
    {
        public List<DateTime> InspectionHistory { get; set; }
        public string Brand { get; set; }

        public string Color { get; set; }

        public string PlateNumber { get; set; }

        public int Year { get; set; }

        public DateTime LastInspection { get; set; }

        public string OwnerName { get; set; }

        public string VehicleType { get; set; }

        public string PassportData { get; set; }

        public string ContactInfo { get; set; }

        public DateTime NextInspectionDate
        {
            get
            {
                return LastInspection.AddYears(1);
            }
        }
    }
}