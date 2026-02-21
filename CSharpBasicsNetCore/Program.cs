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
            NumberParser number = new NumberParser();
            number.Parse("1234567890");
            Console.WriteLine(number);


            //QuadraticEquation equation = new QuadraticEquation(1, 1, 1);
            //double[] xValues = equation.Solve();
            //Console.WriteLine($"Number of solutions: {xValues.Length}");
            //foreach(var value in xValues)
            //{
            //    Console.WriteLine(value);
            //}

            //FizzBuzz x = new FizzBuzz(15);
            //Console.WriteLine(x.Solve());

            double ConvertedTemperature = TemperatureConverter.Convert(ConversionOption.CelciusToKelvin, 0);
            Console.WriteLine(ConvertedTemperature);
        }
    }
}

