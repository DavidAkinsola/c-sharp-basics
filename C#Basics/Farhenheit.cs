namespace C_Basics
{
    public class Farhenheit : Temperature
    {
        public Farhenheit(double value) : base(value) { }

        public override double ToCelcius()
        {
            return (Value - 32) * 5 / 9;
        }

        public override double ToKelvin()
        {
            return ((Value - 32) * 5 / 9) + 273.15;
        }

        public override double ToFahrenheit()
        {
            return Value;
        }

    }
}
