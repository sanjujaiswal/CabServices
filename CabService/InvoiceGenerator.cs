﻿using System;
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
        public InvoiceGenerator()
        {
        }
        public double FareCalculate(double distance, double time)
        {
            double totalFareOfRide = (distance * perKiloMeterCost) + (time * perMinuteCost);
            if (totalFareOfRide < minimumFare)
            {
                return minimumFare;
            }
            return totalFareOfRide;
        }
        public double FareCalculate(MultipleRides[] rides)
        {
            double totalFare = 0;
            foreach (MultipleRides storeRide in rides)
            {
                totalFare += this.FareCalculate(storeRide.distance, storeRide.time);
            }
            if (totalFare < minimumFare)
            {
                return minimumFare;
            }
            return totalFare;
        }
    }
}
