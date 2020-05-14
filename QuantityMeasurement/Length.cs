﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Length
    {
        //// Variables
        Unit unit;
        private double value;

        /// <summary>
        /// Enum class for defines constant 
        /// </summary>
        public enum Unit
        {
            FEET,
            INCH
        };

        /// <summary>
        /// Default Constructor 
        /// </summary>
        public Length()
        { }

        /// <summary>
        /// Parameterised COnstructor 
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Overriding Equals Function.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //If Object is Null It Will Return False.
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            return (this.unit == ((Length)obj).unit) && (this.value == ((Length)obj).value) ||
                 (this.unit.Equals(Unit.FEET) && ((Length)obj).unit.Equals(Unit.INCH)&&
                this.value == 0 && ((Length)obj).value == 0);
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}