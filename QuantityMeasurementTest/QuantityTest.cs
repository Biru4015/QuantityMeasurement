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
        public void Given0Feetand0Feet_WhenCompared_ShouldReturnEqual()
        {
            Quantity feet1 = new Quantity(Unit.FEET,0.0);
            Quantity feet2 = new Quantity(Unit.FEET, 0.0);
            Assert.AreEqual(feet1,feet2);

        }

        /// <summary>
        /// Test case 1.2
        /// Checking instance of Conversion that it is null or not
        /// </summary>
        [Test]
        public void CheckGivenZNullFeetEqualOrNot_WhenCopared_ShouldReturnNullFeet()
        {
            Quantity feet1 = null;
            Quantity feet2 = new Quantity(Unit.FEET, 1.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test case 1.3
        /// Checking instance of Feet that referance is equal or not
        /// </summary>
        [Test]
        public void CheckGivenReferanceFeetEqualToGivenReferanceFeet_WhenChecking_ShouldReturnTrue()
        {
           Quantity firstReferanceFeet = new Quantity();
            Quantity secondReferanceFeet = firstReferanceFeet;
            Assert.AreEqual(firstReferanceFeet, secondReferanceFeet);
        }

        /// <summary>
        /// Test case 1.4
        /// Checking instance of Inch are equal or not
        /// </summary>
        [Test]
        public void CheckGivenZeroInch_WhenCompare_ShouldReturnsTrue()
        {
            Quantity firstInch = new Quantity(Unit.INCH, 0.0);
            Quantity secondInch = new Quantity(Unit.INCH, 0.0);
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
            Quantity firstInch = new Quantity(Unit.FEET, 1.0);
            Quantity secondInch = new Quantity(Unit.INCH, 1.0);
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
            Quantity feet1 = new Quantity(Unit.FEET,0.0);
            Quantity inch1 = new Quantity(Unit.INCH,0.0);
            bool equals = feet1.Equals(inch1);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test 1.7
        /// Checking instance of Inch's and checking enequality
        /// </summary>
        [Test]
        public void CheckGivenFirstInchNotEqualToSecondInch_WhenCompared_ShouldReturnBoolValue()
        {
            Quantity inch1 = new Quantity(Unit.INCH,0.0);
            Quantity inch2 = new Quantity(Unit.INCH,1.0);
            bool equals = inch1.Equals(inch2);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.8
        /// Checking type
        /// </summary>
        [Test]
        public void CheckGivenTypeInchEqual_WhenCompared_ShouldReturnTypeInch()
        {
            Quantity inch1 = new Quantity(Unit.INCH,0.0);
            Quantity inch2 = new Quantity(Unit.INCH, 0.0);
            Assert.AreEqual(inch1.GetType(), inch2.GetType());
        }

        /// <summary>
        /// Test case 1.9
        /// Checking instance of Feet's and checking enequality
        /// </summary>
        [Test]
        public void CheckGivenFirstFeetNotEqualToSecond_WhenCompared_FeetReturnBoolValue()
        {
            Quantity feet1 = new Quantity(Unit.FEET, 0.0);
            Quantity feet2 = new Quantity(Unit.FEET, 1.0);
            bool equals = feet1.Equals(feet2);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test case 1.10
        /// Checking instance of inch that it is null or not
        /// </summary>
        [Test]
        public void CheckGivenZNullInchEqual_WhenCompared_ReturnNullInch()
        {
            Quantity feet1 = null;
            Quantity feet2 = new Quantity(Unit.INCH, 1.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        /// <summary>
        /// Test case 1.11
        /// Checking instance of Inch that referance is equal or not
        /// </summary>
        [Test]
        public void CheckGivenReferanceInchEqualToGivenReferanceInch_WhenCompared_ShouldReturnsEquals()
        {
            Quantity firstReferanceInch = new Quantity();
            Quantity secondReferanceInch = firstReferanceInch;
            Assert.AreEqual(firstReferanceInch, secondReferanceInch);
        }

        /// <summary>
        /// Test case 1.12
        /// Checking 1 feet is not equal to 1 inch
        /// </summary>
        [Test]
        public void CheckGivenOneFeetIsNotEqualToOneInch_WhenConverted_ShouldReturnsEquals()
        {
            Quantity oneFeet = new Quantity(Unit.FEET,1.0);
            Quantity oneInch = new Quantity(Unit.INCH, 1.0);
            Assert.AreNotEqual(oneFeet, oneInch);
        }

        /// <summary>
        /// Test case 1.13
        /// Checking 1 Inch is not equal to 1 Foot
        /// </summary>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneFeet_WhenCalculated_ShouldReturnsTrue()
        {
            Quantity oneInch = new Quantity(Unit.INCH,1.0);
            Quantity oneFeet = new Quantity(Unit.FEET,1.0);
            Assert.AreNotEqual(oneInch, oneFeet);
        }

        /// <summary>
        /// Test case 1.14
        /// Checking 1 Feet is equal to 12 Inch
        /// </summary>
        [Test]
        public void CheckGivenOneFeetIsEqualToTwelveInch_WhenCalculated_ShouldReturnTrue()
        {
            Quantity feet1 = new Quantity(Unit.FEET, 1.0);
            Quantity twelveInch = new Quantity(Unit.INCH, 12.0); 
            Assert.AreEqual(feet1, twelveInch);
        }

        /// <summary>
        /// Test case 1.15
        /// Checking 12 Inch is equal to 1 feet
        /// </summary>
        [Test]
        public void CheckGivenTwelveInchIsEqualToOneFeet_WhenCalculated_ShouldReturnsEquals()
        {
            Quantity twelveInch = new Quantity(Unit.INCH,12.0);
            Quantity feet1 = new Quantity(Unit.FEET, 1.0);
            Assert.AreEqual(twelveInch,feet1);
        }

        /// <summary>
        /// Test case 2.1
        /// Checking 3 Feet is equal to 1 Yard
        /// </summary>
        [Test]
        public void CheckGivenThreeFeetIsEqualToOneYard_WhenCompared_ShouldReturnsEquals()
        {
            Quantity threeFeet = new Quantity(Unit.FEET,3.0);
            Quantity oneYard = new Quantity(Unit.YARD, 1.0);
            Assert.AreEqual(threeFeet,oneYard);
        }

        /// <summary>
        /// Test case 2.2
        /// Checking 1 Feet is not equal to 1 Yard
        /// </summary>
        [Test]
        public void CheckingGivenOneFeetIsNotEqualToOneYard_WhenCompared_ShouldReturnsEquals()
        {
            Quantity oneYard = new Quantity(Unit.YARD, 1.0);
            Quantity threeFeet = new Quantity(Unit.FEET, 3.0);
            Assert.AreEqual(oneYard,threeFeet);
        }

        /// <summary>
        /// Test case 2.3
        /// This test case is checking for one feet and one yard is equals or not
        /// </summary>
        [Test]
        public void CheckGivenOneInchIsNotEqualToOneYard_WhenCompared_ShouldReturnsNotEquals()
        {
            Quantity oneInch = new Quantity(Unit.INCH,1.0);
            Quantity oneYard = new Quantity(Unit.YARD, 1.0);
            Assert.AreNotEqual(oneInch, oneYard);
        }

        /// <summary>
        /// Test case 2.4
        /// This test case for Checking 1 Yard is equal to 36 Inch
        /// </summary>
        [Test]
        public void CheckGivenOneYardIsEqualToThirtySixInch()
        {
            Quantity oneYard = new Quantity(Unit.YARD, 1.0);
            Quantity thirtySixInch = new Quantity(Unit.INCH, 36.0);
            Assert.AreEqual(oneYard,thirtySixInch);
        }

        /// <summary>
        /// Test case 2.5
        /// This test case for Checking 36 Inch is equal to 1 Yard
        /// </summary>
        [Test]
        public void CheckGiventhirtySixInchIsEqualToOneYard_WhenCompared_ShouldReturnsEquals()
        {
            Quantity thirtySixInch = new Quantity(Unit.INCH, 36.0);
            Quantity oneYard = new Quantity(Unit.YARD, 1.0);
            Assert.AreEqual(thirtySixInch,oneYard);
        }

        /// <summary>
        /// Test case 2.6
        /// This test for Checking 1 Yard is equal to 3 Feet
        /// </summary>
        [Test]
        public void CheckGivenOneYardIsEqualToThreeFeet_WhenCompared_ShouldReturnsEquals()
        {
            Quantity oneYard = new Quantity(Unit.YARD, 1.0);
            Quantity threeFeet = new Quantity(Unit.FEET, 3.0);
            Assert.AreEqual(oneYard, threeFeet);
        }

        /// <summary>
        /// Test case 3.1
        /// This test case for checking 2 Inch is equal to 5 Centimetre
        /// </summary>
        [Test]
        public void WhenGivenTwoInch_WhenConverted_ShouldReturnsFiveCentimeter()
        {
            Quantity twoInch = new Quantity(Unit.INCH, 2.0);
            Quantity fiveCentimeter = new Quantity(Unit.CENTIMETER, 5.0);
            Assert.AreEqual(twoInch,fiveCentimeter);
        }

        /// <summary>
        /// Test case  4.1
        /// This test case for checking 2 Inch addition to 2 Inch Equal to 4 inch
        /// </summary>
        [Test]
        public void CheckGivenTwoLengthsInInchForAdd_WhenAdded_ShouldRetunsFourInches()
        {
            Quantity twoInch1 = new Quantity(Unit.INCH,2.0);
            Quantity twoInch2 = new Quantity(Unit.INCH, 2.0);
            double addedQuality = twoInch1.addedQuantity(twoInch2);
            Assert.AreEqual(4,addedQuality);

        }

        /// <summary>
        /// Test case 4.2
        /// This test case is for checking 1 Feet addition to 2 Inch Equal to 14 inch
        /// </summary>
        [Test]
        public void CheckGivenTwoLengthsOneInFeet_WhenAddedTwoLength_ShouldRetuns14Inch()
        {
            Quantity oneFeet = new Quantity(Unit.FEET, 1.0);
            Quantity twoInch = new Quantity(Unit.INCH, 2.0);
            double addedQuality = oneFeet.addedQuantity(twoInch);
            Assert.AreEqual(14, addedQuality);

        }

        /// <summary>
        /// Test case 4.3
        /// This test case is for checking 1 Feet addition to 1 Feet Equal to 24 inch
        /// </summary>
        [Test]
        public void CheckGivenTwoLengthsInFeet_WhenCalculated_ShouldReturns24Inch()
        {
            Quantity oneFeet1 = new Quantity(Unit.FEET, 1.0);
            Quantity oneFeet2 = new Quantity(Unit.FEET, 1.0);
            double addedQuality = oneFeet1.addedQuantity(oneFeet2);
            Assert.AreEqual(24, addedQuality);
        }

        /// <summary>
        /// Test case 4.4
        /// This test case for checking 2 Inch addition to 2.5 Centimeter Equal to 3 inch
        /// </summary>
        [Test]
        public void CheckGivenTwoLengthsOneInInchSecondInCentimeterReturnInInch()
        {
            Quantity twoInch = new Quantity(Unit.INCH, 2.0);
            Quantity centimeter = new Quantity(Unit.CENTIMETER, 2.5);
            double addedQuality = twoInch.addedQuantity(centimeter);
            Assert.AreEqual(3, addedQuality);
        }

        /// <summary>
        /// Test case 5.1
        /// This test case is for checking 1 gallon is equal to 3.78 litres
        /// </summary>
        [Test]
        public void CheckGivenOneGallonToLitre_WhenCompared_ShouldReturnsEquals()
        {
            Quantity oneGallon = new Quantity(Unit.GALLON,1.0);
            Quantity litre = new Quantity(Unit.LITRE, 3.78);
            Assert.AreEqual(oneGallon,litre);
        }

        /// <summary>
        /// Test case 5.2
        /// This test case is created for checking 1 litre is equal to 1000 Mililitres
        /// </summary>
        [Test]
        public void CheckGivenOneLitreEqualToOneThousandMililitre_WhenCompared_ShouldReturnsEquals()
        {
            Quantity oneLitre = new Quantity(Unit.LITRE,1.0);
            Quantity oneMililitres = new Quantity(Unit.MILILITRE, 1000.0);
            Assert.AreEqual(oneLitre,oneMililitres);
        }

        /// <summary>
        /// Test case 6.1
        /// This test case for Checking 1 gallon add to 3.78 litre is equal to 7.56 litres
        /// </summary>
        [Test]
        public void CheckGivenOneGallonAndThreeLitreAddInLitre_WhenCompared_ShouldReturnsEquals()
        {
            Quantity oneGallon = new Quantity(Unit.GALLON, 1.0);
            Quantity litres = new Quantity(Unit.LITRE, 3.78);
            double addedQuantity = oneGallon.addedQuantity(litres);
            Assert.AreEqual(7.56,addedQuantity);
        }

        /// <summary>
        /// Test case 6.2
        /// This test case for checking 1 litre add to 1000 Mililitre is equal to 2 litres
        /// </summary>
        [Test]
        public void CheckGivenOneLitreAndOneThousandMiliLitreAddInLitre_WhenAdded_ShouldReturnsTwoLitres()
        {
            Quantity oneLitre = new Quantity(Unit.LITRE, 1.0);
            Quantity mililitres = new Quantity(Unit.MILILITRE, 1000.0);
            double addedQuantity = oneLitre.addedQuantity(mililitres);
            Assert.AreEqual(2,addedQuantity);
        }

        /// <summary>
        /// Test Case 7.1
        /// This test case is created checking 1 Kilogram is equal to 1000 grams
        /// </summary>
        [Test]
        public void CheckGivenOneKilogram_WhenCompared_ShouldRetuns1000Grams()
        {
            Quantity oneKilogram = new Quantity(Unit.KILOGRAM, 1.0);
            Quantity thousandGram = new Quantity(Unit.GRAM, 1000.0);
            Assert.AreEqual(oneKilogram,thousandGram);
        }

        /// <summary>
        /// Test case 7.2
        /// Checking 1 Tonne is equal to 1000 Kilograms
        /// </summary>
        [Test]
        public void CheckGivenOneTonneIsEqual1000Kg_WhenCompred_ShouldReturnsEquals()
        {
            Quantity oneTonne = new Quantity(Unit.TONNE, 1.0);
            Quantity thousandKilogram = new Quantity(Unit.KILOGRAM, 1000.0);
            Assert.AreEqual(oneTonne, thousandKilogram);
        }

        /// <summary>
        /// Test case 8.1
        /// This test case is created for checking 1 Tonne add to 1000 grams is equal to 1001 Kilograms
        /// </summary>
        [Test]
        public void WhenAdded1TonneAnd1000Gram_WhenAdded_ShouldReturns1001Kg()
        {
            Quantity oneTonne = new Quantity(Unit.TONNE, 1.0);
            Quantity thousandGram = new Quantity(Unit.GRAM, 1000.0);
            double addedQuantity = oneTonne.addedQuantity(thousandGram);
            Assert.AreEqual(1001, addedQuantity);
        }

        /// <summary>
        ///  Test case 8.2
        ///  This test case is created for checking 500kg and 600kg and should returns 1100 kg
        /// </summary>
        [Test]
        public void WhenAdded500KgAnd600Kg_WhenAdded_ShouldReturns110Kg()
        {
            Quantity kilogram1 = new Quantity(Unit.KILOGRAM, 500.0);
            Quantity kilogram2 = new Quantity(Unit.KILOGRAM, 600.0);
            double addedQuantity = kilogram1.addedQuantity(kilogram2);
            Assert.AreEqual(1100, addedQuantity);
        }

        /// <summary>
        /// Test case 9.1
        /// This tes case is for checking conversion of Temperature
        /// Fahrenhiet to Celsius
        /// </summary>
        [Test]
        public void CheckTemperatureConversionFahrenhiteToCelsius_WhenCompared_ShouldReturnsEquals()
        {
            Quantity celcius = new Quantity(Unit.CELCIUS, 100.0);
            Quantity fahrenhiet = new Quantity(Unit.FAHRENHIET, 212.0);
            Assert.AreEqual(celcius,fahrenhiet);
        }

        /// <summary>
        /// Test case 9.2
        /// This test case is created for conversion of Tempreture
        /// CelsiusToFahrenhiet
        /// </summary>
        [Test]
        public void CheckingTempretureConversionCelsiusToFahrenhiet_WhenCompared_ShouldReturnsEquals()
        {
            Quantity fahrenhiet = new Quantity(Unit.FAHRENHIET,212.0);
            Quantity celcius = new Quantity(Unit.CELCIUS, 100.0);
            Assert.AreEqual(fahrenhiet,celcius);
        }
    }
}