using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Weight
    {
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
        /// Default Constructor 
        /// </summary>
        public Weight()
        { }

        /// <summary>
        /// Parameterised COnstructor
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Weight(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Weight Conversion Logic part
        /// </summary>
        /// <param name="conversion"></param>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public double WeightConversion(string conversion, double givenValue)
        {
            switch (conversion)
            {
                case "KilogramToGram":
                    double kilogramToGram = givenValue * 1000;
                    return kilogramToGram;
                case "GramToKilogram":
                    double gramToKilogram = givenValue / 1000;
                    return gramToKilogram;
                case "TonneToKilogram":
                    double tonneToKilogram = givenValue * 1000;
                    return tonneToKilogram;
                default:
                    Console.WriteLine("Invalid Conversion");
                    return 0;
            }
        }
    }
}