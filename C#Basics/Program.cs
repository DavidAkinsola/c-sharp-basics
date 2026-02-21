using C_Basics.BusinessLogics;
using System;

namespace C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //all outputs (console.writeline) should be in main method.
            //
            NumberParser number = new NumberParser("1234567890");
            //Console.WriteLine(number.ParseAmericanNumber());

            QuadraticEquation equation = new QuadraticEquation(1, -3, 2);
            Console.WriteLine(equation.Solutions());

            FizzBuzz x = new FizzBuzz(15);
            Console.WriteLine(x.Solve());

            Temperature c = new Celcius(0);
            Temperature f = new Farhenheit(212);
            Temperature k = new Kelvin(273);

            Console.WriteLine(c.ToKelvin());
            Console.WriteLine(f.ToFahrenheit());
            Console.WriteLine(k.ToCelcius());

            //TemperatureConverter(DegreeType.C, 0, DegreeType.F);
            //TemperatureConverter(DegreeType.F, 212, DegreeType.C);
            //TemperatureConverter(DegreeType.Celcius, 100, DegreeType.Kelvin);
            //TemperatureConverter(DegreeType.K, 0, DegreeType.F);
            //TemperatureConverter(DegreeType.F, 32, DegreeType.K);
            //TemperatureConverter(DegreeType.K, -10, DegreeType.C);
        }
    }
}
