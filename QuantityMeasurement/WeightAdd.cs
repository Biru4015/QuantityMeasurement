using System;
using System.Collections.Generic;
using System.Text;
using static QuantityMeasurement.Length;

namespace QuantityMeasurement
{
    public class WeightAdd
    {
        Weight weight = new Weight();

        //// Variables
        Unit unit;
        private double value;

        public enum Unit
        {
            KILOGRAM,
            GRAMS,
            TONNE
        };
        /// <summary>
        /// Adding two weights in grams
        /// if its unit is not in gram then we are converting it in grams
        /// and making addition of it.
        /// </summary>
        /// <param name="unitOne"></param>
        /// <param name="valueOne"></param>
        /// <param name="unitTwo"></param>
        /// <param name="valueTwo"></param>
        /// <returns></returns>
        public double AddTwoWeightInGrams(Unit unitOne, double valueOne, Unit unitTwo, double valueTwo)
        {
            double firstValueInGrams = valueOne;
            double secondValueInGrams = valueTwo;

            if (unitOne == Unit.TONNE)
            {
                firstValueInGrams =weight.WeightConversion("TonneToKilogram", valueOne);
            }
            if (unitTwo == Unit.GRAMS)
            {
                secondValueInGrams =weight.WeightConversion("GramToKilogram", valueTwo);
            }
            return firstValueInGrams + secondValueInGrams;
        }
    }
}