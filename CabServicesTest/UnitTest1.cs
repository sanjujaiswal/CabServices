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
            InvoiceGenerator invoiceGen = new InvoiceGenerator(travelDistance, travelTime);
            Assert.AreEqual(105, invoiceGen.CalculateCabFare());
        }
    }
}