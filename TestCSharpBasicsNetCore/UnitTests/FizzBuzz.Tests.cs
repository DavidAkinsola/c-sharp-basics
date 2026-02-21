using C_Basics.BusinessLogics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharpBasicsNetCore.UnitTests
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Solve_WhenNumberIsMultipleOf3_ReturnsFizz()
        {
            // Arrange
            var FizzBuzzTest1 = new FizzBuzz(3);
            var FizzBuzzTest2 = new FizzBuzz(6);
            

            // Act
            string result1 = FizzBuzzTest1.Solve();
            string result2 = FizzBuzzTest2.Solve();
            

            // Assert
            Assert.Equal("Fizz", result1);
            Assert.Equal("Fizz", result2);
        }

        [Fact]
        public void Solve_WhenNumberIsMultipleOf5_ReturnsBuzz()
        {
            // Arrange
            var FizzBuzzTest1 = new FizzBuzz(5);
            var FizzBuzzTest2 = new FizzBuzz(10);
           

            // Act
            string result1 = FizzBuzzTest1.Solve();
            string result2 = FizzBuzzTest2.Solve();
            

            // Assert
            Assert.Equal("Buzz", result1);
            Assert.Equal("Buzz", result2);
            
        }

        [Fact]
        public void Solve_WhenNumberIsMultipleOf3And5_ReturnsFizzBuzz()
        {
            // Arrange
            var FizzBuzzTest1 = new FizzBuzz(15);

            // Act
            string result1 = FizzBuzzTest1.Solve();
           
            // Assert          
            Assert.Equal("FizzBuzz", result1);
        }

        [Fact]
        public void Solve_WhenNumberIsNotMultipleOf3And5_ReturnsNumberAsString()
        {
            // Arrange
            var FizzBuzzTest1 = new FizzBuzz(7);
            var FizzBuzzTest2 = new FizzBuzz(2);
            

            // Act
            string result1 = FizzBuzzTest1.Solve();
            string result2 = FizzBuzzTest2.Solve();
            

            // Assert
            Assert.Equal("7", result1);
            Assert.Equal("2", result2);
        }
    }
}
