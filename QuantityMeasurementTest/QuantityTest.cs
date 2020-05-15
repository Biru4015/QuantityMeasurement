using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityMeasurementTest
{
    public class QuantityTest
    {
        /// <summary>
        /// Object of length class
        /// </summary>
        readonly Length lengthConversion = new Length();


        /// <summary>
        /// Test case 1.1
        /// When given 0 feet and 0 feet are equals or not
        /// </summary>
        [Test]
        public void Given0Feetand0Feet_WhenCompared_ShouldReturnEqual()
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
        public void CheckGivenZeroFeetAndZeroInchAreEqual_WhenAnalyse_ShouldReturnsEquals()
        {
            double zeroFeet = lengthConversion.LengthConversion("FeetToInch", 0.0);
            double zeroInch = lengthConversion.LengthConversion("InchToFeet", 0.0);
            Assert.AreEqual(zeroFeet, zeroInch);
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
            double oneFeet = lengthConversion.LengthConversion("FeetToInch", 1.0);
            double oneInch = lengthConversion.LengthConversion("InchToFee", 1.0);
            Assert.AreNotEqual(oneFeet, oneInch);
        }

        /// <summary>
        /// Test case 1.13
        /// Checking 1 Inch is not equal to 1 Foot
        /// </summary>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneFeet_WhenCalculated_ShouldReturnsTrue()
        {
            double oneInch = lengthConversion.LengthConversion("InchToFeet", 1.0);
            double oneFeet = lengthConversion.LengthConversion("FeetToInch", 1.0);
            Assert.AreNotEqual(oneInch, oneFeet);
        }

        /// <summary>
        /// Test case 1.14
        /// Checking 1 Feet is equal to 12 Inch
        /// </summary>
        [Test]
        public void CheckGivenOneFeetIsEqualToTwelveInch_WhenCalculated_ShouldReturnTrue()
        {
            double oneFeet = lengthConversion.LengthConversion("FeetToInch", 1.0);
            double twelveInch = 12.0;
            Assert.AreEqual(oneFeet, twelveInch);
        }

        /// <summary>
        /// Test case 1.15
        /// Checking 12 Inch is equal to 1 feet
        /// </summary>
        [Test]
        public void CheckGivenTwelveInchIsEqualToOneFeet_WhenCalculated_ShouldReturnsEquals()
        {
            double oneFeet = 1.0;
            double twelveInch = lengthConversion.LengthConversion("InchToFeet", 12.0);
            Assert.AreEqual(oneFeet, twelveInch);
        }

        /// <summary>
        /// Test case 2.1
        /// Checking 3 Feet is equal to 1 Yard
        /// </summary>
        [Test]
        public void CheckGivenThreeFeetIsEqualToOneYard_WhenCompared_ShouldReturnsEquals()
        {
            double threeFeet = lengthConversion.LengthConversion("FeetToYard", 3.0);
            double oneYard = 1.0;
            Assert.AreEqual(oneYard, threeFeet);
        }

        /// <summary>
        /// Test case 2.2
        /// Checking 1 Feet is not equal to 1 Yard
        /// </summary>
        [Test]
        public void CheckingGivenOneFeetIsNotEqualToOneYard_WhenCompared_ShouldReturnsEquals()
        {
            double oneFeet = 1.0;
            double oneYard = lengthConversion.LengthConversion("YardToFeet", 1.0);
            Assert.AreNotEqual(oneFeet, oneYard);
        }

        /// <summary>
        /// Test case 2.3
        /// This test case is checking for one feet and one yard is equals or not
        /// </summary>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneYard_WhenCompared_ShouldReturnsNotEquals()
        {
            double oneInch = 1.0;
            double oneYard = lengthConversion.LengthConversion("InchToYard", 1.0);
            Assert.AreNotEqual(oneInch, oneYard);
        }

        /// <summary>
        /// Test case 2.4
        /// This test case for Checking 1 Yard is equal to 36 Inch
        /// </summary>
        [Test]
        public void CheckGivenOneYardIsEqualToThirtySixInch()
        {
            double thirtySixInch = 36.0;
            double oneYard = lengthConversion.LengthConversion("YardToInch", 1.0);
            Assert.AreEqual(thirtySixInch, oneYard);
        }

        /// <summary>
        /// Test case 2.5
        /// This test case for Checking 36 Inch is equal to 1 Yard
        /// </summary>
        [Test]
        public void CheckGiventhirtySixInchIsEqualToOneYard_WhenCompared_ShouldReturnsEquals()
        {
            double thirtySixInch = lengthConversion.LengthConversion("InchToYard", 36.0);
            double oneYard = 1.0;
            Assert.AreEqual(oneYard, thirtySixInch);
        }

        /// <summary>
        /// Test case 2.6
        /// This test for Checking 1 Yard is equal to 3 Feet
        /// </summary>
        [Test]
        public void CheckGivenOneYardIsEqualToThreeFeet_WhenCompared_ShouldReturnsEquals()
        {
            double oneYard = lengthConversion.LengthConversion("YardToFeet", 1.0);
            double threeFeet = 3.0;
            Assert.AreEqual(threeFeet, oneYard);
        }

        /// <summary>
        /// Test case 3.1
        /// This test case for checking 2 Inch is equal to 5 Centimetre
        /// </summary>
        [Test]
        public void WhenGivenTwoInch_WhenConverted_ShouldReturnsFiveCentimeter()
        {
            double twoInch = lengthConversion.LengthConversion("InchToCentimeter", 2.0);
            double fiveCentimeter = 5.0;
            Assert.AreEqual(fiveCentimeter, twoInch);
        }

        /// <summary>
        /// Test case  4.1
        /// This test case for checking 2 Inch addition to 2 Inch Equal to 4 inch
        /// </summary>
        [Test]
        public void CheckGivenTwoLengthsInInchForAdd_WhenAdded_ShouldRetunsFourInches()
        {
            double twoInch = lengthConversion.AddTwoLenghtsInInch(Length.Unit.INCH, 2, Length.Unit.INCH, 2);
            double addTwoInch = 4.0;
            Assert.AreEqual(twoInch, addTwoInch);
        }

        /// <summary>
        /// Test case 4.2
        /// This test case is for checking 1 Feet addition to 2 Inch Equal to 14 inch
        /// </summary>
        [Test]
        public void CheckGivenTwoLengthsOneInFeet_WhenAddedTwoLength_ShouldRetuns14Inch()
        {
            double oneFeetOneInch = lengthConversion.AddTwoLenghtsInInch(Length.Unit.FEET, 1, Length.Unit.INCH, 2);
            double addTwoInch = 14.0;
            Assert.AreEqual(addTwoInch, oneFeetOneInch);
        }

        /// <summary>
        /// Test case 4.3
        /// This test case is for checking 1 Feet addition to 1 Feet Equal to 24 inch
        /// </summary>
        [Test]
        public void CheckGivenTwoLengthsInFeet_WhenCalculated_ShouldReturns24Inch()
        {
            double addTwoFeet = lengthConversion.AddTwoLenghtsInInch(Length.Unit.FEET, 1, Length.Unit.FEET, 1);
            double addTwoInch = 24.0;
            Assert.AreEqual(addTwoInch, addTwoFeet);
        }

        /// <summary>
        /// Test case 4.4
        /// This test case for checking 2 Inch addition to 2.5 Centimeter Equal to 3 inch
        /// </summary>
        [Test]
        public void CheckGivenTwoLengthsOneInInchSecondInCentimeterReturnInInch()
        {
            double oneInchOneCentimeter = lengthConversion.AddTwoLenghtsInInch(Length.Unit.INCH, 2, Length.Unit.CENTIMETER, 2.5);
            double addTwoInch = 3.0;
            Assert.AreEqual(addTwoInch, oneInchOneCentimeter);
        }
    }
}