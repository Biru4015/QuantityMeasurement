using System;
using QuantityMeasurement;

namespace QuantityMeasurement
{
    public class Conversion
    {
        public double feet;

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO QUANTITY MEASUREMENT TTD PROBLEM!!");
        }

        /// <summary>
        /// Method to Feet
        /// </summary>
        /// <param name="input"> input </param>
        /// <returns> Calculate Feet </returns>
        public double Feetmeasure(double input)
        {
            return feet = 12 * input;
        }
    }
}
