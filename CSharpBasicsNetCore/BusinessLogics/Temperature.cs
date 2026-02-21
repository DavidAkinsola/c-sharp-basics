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

    public enum ConversionOption
    {
        CelciusToKelvin,
        CelciusToFahrenheit,
        KelvinToCelcius,
        KelvinToFahrenheit,
        FahrenheitToCelcius,
        FahrenheitToKelvin
    }
    public static class TemperatureConverter
    {
        //use THIS class to do everything!!

        public static double Convert(ConversionOption option, double value)
        {
            switch (option)
            {
                case ConversionOption.CelciusToFahrenheit:
                    return Math.Round((value * (9 / 5)) + 32, 2);
                case ConversionOption.CelciusToKelvin:
                    return Math.Round(value +273.15, 2);
                case ConversionOption.FahrenheitToCelcius:
                    return Math.Round((value - 32) * 5 / 9, 2);
                case ConversionOption.FahrenheitToKelvin:
                    return Math.Round((value - 32) * (5 / 9) + 273.15, 2);
                case ConversionOption.KelvinToCelcius:
                    if (value < 0)
                        throw new ArgumentException("Invalid Kelvin Temperature");
                    return Math.Round(value - 273.15, 2);
                case ConversionOption.KelvinToFahrenheit:
                    if (value < 0)
                        throw new ArgumentException("Invalid Kelvin Temperature");
                    return Math.Round((value - 273.15) * 1.8 + 32, 2);
                default:
                    throw new ArgumentException("Invalid conversion option");
            }
        }

        //public string ConvertToCelcius()
        //{
        //    switch (DegreeType)
        //    {
        //        case DegreeType.Fahrenheit:
        //            return $"{(Value - 32) * 5 / 9} C";
        //        case DegreeType.Kelvin:
        //            return $"{Value - 273.15} C";
        //        default:
        //            return $"{Value} C";
        //    }
        //}

        //public string ConvertToFahrenheit()
        //{
        //    switch (DegreeType)
        //    {
        //        case DegreeType.Celcius:
        //            return $"{(Value * (9 / 5)) + 32} F";
        //        case DegreeType.Kelvin:
        //            return $"{(Value - 273.15) * 9 / 5 + 32} F";
        //        default:
        //            return $"{Value} F";
        //    }
        //}

        //public string ConvertToKelvin()
        //{
        //    if (Value < 0)
        //        return "Kelvin cannot be less than 0"; 

        //    switch (DegreeType)
        //    {
        //        case DegreeType.Celcius:
        //            return $"{Value + 273.15} K";
        //        case DegreeType.Fahrenheit:
        //            return $"{(Value - 32) * (5 / 9) + 273.15} K";
        //        default:
        //            return $"{Value} K";
        //    }
        //}

    }
}
