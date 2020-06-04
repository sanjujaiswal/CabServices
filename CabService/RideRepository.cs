using System;
using System.Collections.Generic;
using System.Text;

namespace CabService
{
    public class RideRepository
    {
        Dictionary<string, List<MultipleRides>> userRideObject = new Dictionary<string, List<MultipleRides>>();
        public void AddInRide(string userId, MultipleRides[] rides)
        {
            bool checkForRide = userRideObject.ContainsKey(userId);
            if (checkForRide == false)
            {
                List<MultipleRides> list = new List<MultipleRides>();
                list.AddRange(rides);
                userRideObject.Add(userId, list);
            }
        }
        public MultipleRides[] GetRides(string userId)
        {
            return userRideObject[userId].ToArray();
        }
    }
}
