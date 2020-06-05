using System;
using System.Collections.Generic;
using System.Text;

namespace CabService
{
    public class RideType
    {
        public static readonly string normalRide = "noemal";
        public static readonly string premiumRide = "premium";
        public readonly int perTimeCost;
        public readonly double minimumPerKilometerCost;
        public readonly double minimumFare;

        public RideType(string rideType)
        {
            if (rideType.ToLower() == premiumRide)
            {
                perTimeCost = 2;
                minimumPerKilometerCost = 15;
                minimumFare = 20;
            }
            else
            {
                perTimeCost = 1;
                minimumPerKilometerCost = 10;
                minimumFare = 5;
            }
        }
    }
}
