using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using System.Xml.Schema;

namespace CabService
{
    public class InvoiceSummary
    {
        /// <summary>
        /// set and get are used to assign a value and return it.
        /// </summary>
        public int totalRides { get; set; }
        public double totalFare { get; set; }
        public double averageFarePerRide { get; set; }

        /// <summary>
        /// Calculated average fare per ride
        /// </summary>
        public void AverageFareCalculate()
        {
            averageFarePerRide = totalFare / totalRides;
        }
    }
}
