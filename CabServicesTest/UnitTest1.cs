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
        [Test]
        public void TakeDistanceAndTimeReturnTotalFare()
        {
            double travelDistance = 10.0;
            double travelTime = 5;
            InvoiceGenerator invoiceGen = new InvoiceGenerator();
            Assert.AreEqual(105, invoiceGen.FareCalculate(travelDistance,travelTime));
        }

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
    }
}