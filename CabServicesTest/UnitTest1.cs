using CabService;
using NUnit.Framework;

namespace CabServicesTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //Test1
        [Test]
        public void TakeDistanceAndTimeReturnTotalFare()
        {
            double travelDistance = 10.0;
            double travelTime = 5;
            InvoiceGenerator invoiceGen = new InvoiceGenerator();
            Assert.AreEqual(105, invoiceGen.FareCalculate(travelDistance,travelTime));
        }

        //Test2
        [Test]
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {
            MultipleRides[] rides =
                {
                new MultipleRides(5.0,2.0),new MultipleRides(3.8,2.5)
                };
            InvoiceGenerator invoiceGen = new InvoiceGenerator();
            Assert.AreEqual(92.5, invoiceGen.FareCalculate(rides));
        }

        //Test3
        [Test]
        public void GivenDistanceAndTimeOfMultiRidesToInvoiceGeneratorShouldInhancedInvoice()
        {
            bool exceptedInvoice = true;
            bool returnInvoice = false;
            InvoiceGenerator invoiceGen = new InvoiceGenerator();

            MultipleRides[] rides =
            {
                new MultipleRides(5.5,2.5), new MultipleRides(3.0,1.0)
            };
            InvoiceSummary returnSummary = invoiceGen.CalculateCabFare(rides);
            InvoiceSummary expectedSummery = new InvoiceSummary
            {
                totalRides = 2,
                totalFare = 88.5,
                averageFarePerRide = 44.25
            };
            if (returnSummary.totalRides == expectedSummery.totalRides && returnSummary.totalFare == expectedSummery.totalFare && returnSummary.averageFarePerRide == expectedSummery.averageFarePerRide)
            {
                returnInvoice = true;
            }
            Assert.AreEqual(exceptedInvoice, returnInvoice);
        }

        [Test]
        public void GivenDistanceAndTimeOfMultiRidesToUserIdShouldTotalFare()
        {
            string userId = "sanju@357";
            InvoiceGenerator invoiceGen = new InvoiceGenerator();
            MultipleRides[] rides =
            {
                new MultipleRides(3.0,1.0),
                new MultipleRides(3.5,1.5)
            };
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddInRide(userId, rides);
            InvoiceSummary retunTotal = invoiceGen.CalculateCabFare(rideRepository.GetRides(userId));
            Assert.AreEqual(67.5, retunTotal.totalFare);

        }
    }
    }