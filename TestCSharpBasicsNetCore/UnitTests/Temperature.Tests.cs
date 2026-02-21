using C_Basics;
using C_Basics.BusinessLogics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharpBasicsNetCore.UnitTests
{
    public class TemperatureConverterTest
    {
        [Fact]
        public void Convert_ReturnsValue_ConvertsToCelcius()
        {
            // Arrange
            // Act
            double temperature1 = TemperatureConverter.Convert(ConversionOption.FahrenheitToCelcius, 212);

            // Assert
            Assert.Equal(100, temperature1);
            
        }

        [Fact]
        public void Convert_ReturnsValue_ConvertsToFahrenheit()
        {
            // Arrange
            // Act
            double temperature1 = TemperatureConverter.Convert(ConversionOption.CelciusToFahrenheit, 0);
            double temperature2 = TemperatureConverter.Convert(ConversionOption.KelvinToFahrenheit, 0);


            // Assert
            Assert.Equal(32, temperature1);
            Assert.Equal(-459.67, temperature2);

        }

        [Fact]
        public void Convert_ReturnsValue_ConvertsToKelvin()
        {
            // Arrange
            // Act
            double temperature1 = TemperatureConverter.Convert(ConversionOption.CelciusToKelvin, 100);
            double temperature2 = TemperatureConverter.Convert(ConversionOption.FahrenheitToKelvin, 32);


            // Assert
            Assert.Equal(373.15, temperature1);
            Assert.Equal(273.15, temperature2);

        }

        [Fact]
        public void Convert_ThrowsException_WhenKelvinValueisLessThanZero()
        {
            // Arrange
            // Act
            
            // Assert
            var exception1 = Assert.Throws<ArgumentException>(() => 
                TemperatureConverter.Convert(ConversionOption.KelvinToFahrenheit, -10));
            var exception2 = Assert.Throws<ArgumentException>(() => 
                TemperatureConverter.Convert(ConversionOption.KelvinToCelcius, -32));

            Assert.Equal("Invalid Kelvin Temperature", exception1.Message);
            Assert.Equal("Invalid Kelvin Temperature", exception2.Message);

        }
    }
}
