using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityMeasurementTest
{
    public class QuantityTest
    {
        /// <summary>
        /// Test case 1.1
        /// When given 0 feet and 0 feet are equals or not
        /// </summary>
        [Test]
        public void given0Feetand0Feet_ShouldReturnEqual()
        {
            Conversion converstion = new Conversion();
            double feet1 = 0.0;
            double feet2 = converstion.Feetmeasure(0.0);
            Assert.AreEqual(feet1,feet2);
        }
    }
}