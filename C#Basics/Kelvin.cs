namespace C_Basics
{
    public class Kelvin : Temperature
    {
        public Kelvin(double value) : base(value) { }

        protected override bool IsValidValue(double value)
        {
            return value > 0;
        }
        public override double ToCelcius()
        {
            return Value - 273.15;
        }

        public override double ToFahrenheit()
        {
                return ((Value - 32) * 5 / 9) + 273.15;
        }

        public override double ToKelvin()
        {
            return Value;
        }

    }
}
