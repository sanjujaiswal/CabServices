using CabService;
using NUnit.Framework;
using System.Collections.Generic;

namespace CabServicesTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //Premium ride 
        [Test]
        public void GivenPremiumRide_ShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            string userId = "Sanju";
            Ride firstRide = new Ride(3.0, 5, "Premium");
            Ride secondRide = new Ride(2, 1, "Normal");

            List<Ride> rides = new List<Ride> { firstRide, secondRide };
            UserAccounts.AddRides(userId, rides);
            InvoiceSummary invoiceSummary = invoiceGenerator.GetInvoiceSummary(userId);
            InvoiceSummary expected = new InvoiceSummary
            {
                totalRides = 2,
                totalFare = 106,
                averageFarePerRide = 53
            };
            Assert.AreEqual(expected.totalFare, invoiceSummary.totalFare);
        }
    }
    }