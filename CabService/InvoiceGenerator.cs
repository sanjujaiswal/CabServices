using System;
using System.Collections.Generic;
using System.Text;

namespace CabService
{
    public class InvoiceGenerator
    {
        //Variable declaration
        readonly private double distance;
        readonly private double time;
        readonly private double perKiloMeterCost = 10.0;
        readonly private double perMinuteCost = 1.0;
        readonly private double minimumFare = 5.0;

        /// <summary>
        /// Calculated total fair of ride
        /// </summary>
        /// <param name="travelDistance"></param>
        /// <param name="travelTime"></param>
        public InvoiceGenerator(double travelDistance, double travelTime)
        {
            this.distance = travelDistance;
            this.time = travelTime;
        }
        public double CalculateCabFare()
        {
            double totalFareOfRide = (distance * perKiloMeterCost) + (time * perMinuteCost);
            if (totalFareOfRide < minimumFare)
            {
                return minimumFare;
            }
            return totalFareOfRide;
        }
    }
}
