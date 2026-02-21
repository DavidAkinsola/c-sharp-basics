using System;

namespace C_Basics
{
    //bring back enum!!
    public enum DegreeType
    {
        Celcius, 
        Fahrenheit,
        Kelvin
    }
    public abstract class Temperature
    {
        //use THIS class to do everything!!
        public double Value { get; set; }
        public DegreeType DegreeType { get; set; }

        public Temperature(double value)
        {
            this.Value = value;
            this.DegreeType = DegreeType.Celcius;

            //fix this, ArgumentOutOfRangeExceptions are used in collections
            if (!IsValidValue(value))
                throw new ArgumentOutOfRangeException(nameof(value), value, "Kelvin cannot be negative");
        }

        protected virtual bool IsValidValue(double value)
        {
            return true;
        }

        public abstract double ToCelcius();
        public abstract double ToFahrenheit();
        public abstract double ToKelvin();
    }
}
