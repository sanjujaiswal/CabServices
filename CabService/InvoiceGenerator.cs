using System;
using System.Collections.Generic;
using System.Text;

namespace CabService
{
    public class InvoiceGenerator
    {
        public double CalculateFare(double distance, int time, string type = "normal")
        {
            RideType rideType = new RideType(type);
            double totalFare = distance * rideType.minimumPerKilometerCost + time * rideType.perTimeCost;
            if (totalFare < rideType.minimumFare)
            {
                return rideType.minimumFare;
            }
            return totalFare;
        }

        public InvoiceSummary GetInvoiceSummary(string userId)
        {
            if (userId is null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (UserAccounts.account.ContainsKey(userId))
            {
                double totalFare = 0;
                int numberOfRides = 0;
                InvoiceSummary invoiceSummary = new InvoiceSummary();
                foreach (Ride ride in UserAccounts.account[userId])
                {
                    totalFare += this.CalculateFare(ride.distance, ride.time, ride.rideType);
                    numberOfRides++;
                }
                invoiceSummary.averageFarePerRide = numberOfRides;
                invoiceSummary.totalFare = totalFare;
                invoiceSummary.AverageFareCalculate();
                return invoiceSummary;
            }
            else
            {
                throw new InvoiceException(InvoiceException.InvalidServiceException.invalidUserId, "Wrong user Id");
            }

        }
    }
}