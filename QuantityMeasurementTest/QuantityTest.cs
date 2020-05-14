using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityMeasurementTest
{
    public class QuantityTest
    {
        /// <summary>
        /// Object of length class
        /// </summary>
        Length lengthConversion = new Length();

        /// <summary>
        /// Test case 1.1
        /// When given 0 feet and 0 feet are equals or not
        /// </summary>
        [Test]
        public void given0Feetand0Feet_WhenCompared_ShouldReturnEqual()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.FEET, 0.0);
            bool equals = firstFeet.Equals(secondFeet);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test case 1.2
        /// Checking instance of Conversion that it is null or not
        /// </summary>
        [Test]
        public void CheckGivenZNullFeetEqualOrNot_WhenCopared_ShouldReturnNullFeet()
        {
            bool equals = Length.Equals(Length.Unit.FEET, null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.3
        /// Checking instance of Feet that referance is equal or not
        /// </summary>
        [Test]
        public void CheckGivenReferanceFeetEqualToGivenReferanceFeet_WhenChecking_ShouldReturnTrue()
        {
            Length firstReferanceFeet = new Length();
            Length secondReferanceFeet = firstReferanceFeet;
            Assert.AreEqual(firstReferanceFeet, secondReferanceFeet);
        }

        /// <summary>
        /// Test case 1.4
        /// Checking instance of Inch are equal or not
        /// </summary>
        [Test]
        public void CheckGivenZeroInch_WhenCompare_ShouldReturnsTrue()
        {
            Length firstInch = new Length(Length.Unit.INCH, 0.0);
            Length secondInch = new Length(Length.Unit.INCH, 0.0);
            bool equals = firstInch.Equals(secondInch);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test case 1.5
        /// When given 1 feet and 1 inch returns not equals
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenCompared_ShouldReturnsFalse()
        {
            Length firstInch = new Length(Length.Unit.FEET, 1.0);
            Length secondInch = new Length(Length.Unit.INCH, 1.0);
            bool equals = firstInch.Equals(secondInch);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.6
        /// Checking instance of Length are equal or not Checking Inch Feet Equality
        /// </summary>
        [Test]
        public void CheckGivenZeroFeetAndZeroInchAreEqual()
        {
            Length firstFeet = new Length(Length.Unit.FEET, 0.0);
            Length secondFeet = new Length(Length.Unit.INCH, 0.0);
            Assert.AreEqual(firstFeet, secondFeet);
        }

        /// <summary>
        /// Test 1.7
        /// Checking instance of Inch's and checking enequality
        /// </summary>
        [Test]
        public void CheckGivenFirstInchNotEqualToSecondInch_WhenCompared_ShouldReturnBoolValue()
        {
            Length firstInchValue = new Length(Length.Unit.INCH, 1.0);
            Length secondInchValue = new Length(Length.Unit.INCH, 0.0);
            bool equals = firstInchValue.Equals(secondInchValue);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.8
        /// Checking type
        /// </summary>
        [Test]
        public void CheckGivenTypeInchEqual_WhenCompared_ShouldReturnTypeInch()
        {
            Length firstInchValue = new Length(Length.Unit.INCH, 0.0);
            Length secondInchValue = new Length(Length.Unit.INCH, 0.0);
            Assert.AreEqual(firstInchValue.GetType(), secondInchValue.GetType());
        }

        /// <summary>
        /// Test case 1.9
        /// Checking instance of Feet's and checking enequality
        /// </summary>
        [Test]
        public void CheckGivenFirstFeetNotEqualToSecond_WhenCompared_FeetReturnBoolValue()
        { 
            Length firstFeetValue = new Length(Length.Unit.FEET, 1.0);
            Length secondFeetValue = new Length(Length.Unit.FEET, 0.0);
            bool equals = firstFeetValue.Equals(secondFeetValue);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.10
        /// Checking instance of inch that it is null or not
        /// </summary>
        [Test]
        public void CheckGivenZNullInchEqual_WhenCompared_ReturnNullInch()
        {
            bool equals = Length.Equals(Length.Unit.INCH, null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.11
        /// Checking instance of Inch that referance is equal or not
        /// </summary>
        [Test]
        public void CheckGivenReferanceInchEqualToGivenReferanceInch_WhenCompared_ShouldReturnsEquals()
        {
            Length firstReferanceInch = new Length();
            Length secondReferanceInch = firstReferanceInch;
            Assert.AreEqual(firstReferanceInch, secondReferanceInch);
        }

        /// <summary>
        /// Test case 1.12
        /// Checking 1 feet is not equal to 1 inch
        /// </summary>
        [Test]
        public void CheckGivenOneFeetIsNotEqualToOneInch_WhenConverted_ShouldReturnsEquals()
        {
            double oneFeet = lengthConversion.FeetToInch(1.0);
            double oneInch = lengthConversion.InchToFeet(1.0);
            Assert.AreNotEqual(oneFeet, oneInch);
        }

        /// <summary>
        /// Test case 1.13
        /// Checking 1 Inch is not equal to 1 Foot
        /// </summary>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneFeet_WhenCalculated_ShouldReturnsTrue()
        {
            double oneInch = lengthConversion.InchToFeet(1.0);
            double oneFeet = lengthConversion.FeetToInch(1.0);
            Assert.AreNotEqual(oneInch, oneFeet);
        }

        /// <summary>
        /// Test case 1.14
        /// Checking 1 Feet is equal to 12 Inch
        /// </summary>
        [Test]
        public void CheckGivenOneFeetIsEqualToTwelveInch_WhenCalculated_ShouldReturnTrue()
        {
            double oneFeet = lengthConversion.FeetToInch(1.0);
            double twelveInch = 12.0;
            Assert.AreEqual(oneFeet, twelveInch);
        }
    }
}