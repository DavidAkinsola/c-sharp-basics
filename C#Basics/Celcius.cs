namespace C_Basics
{
    public class Celcius: Temperature
    {
        public Celcius(double value) : base(value) { }

        public override double ToFahrenheit()
        {
            return (Value * 9 / 5) + 32;
        }

        public override double ToKelvin()
        {
            return Value + 273.15;
        }

        public override double ToCelcius()
        {
            return Value;
        }
        
    }
}
