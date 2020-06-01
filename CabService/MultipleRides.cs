using System;
using System.Collections.Generic;
using System.Text;

namespace CabService
{
    public class MultipleRides
    {
        readonly public double distance;
        readonly public double time;
        public MultipleRides(double rideDistance, double rideTime)
        {
            this.distance = rideDistance;
            this.time = rideTime;
        }
    }
}
