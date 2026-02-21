using C_Basics.BusinessLogics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharpBasicsNetCore.UnitTests
{
    public class QuadraticEquationTest
    {
        [Fact]
        public void GetDeterminant_ReturnsDeterminantValue()
        {
            // Arrange
            var equation1 = new QuadraticEquation(1, -3, 2);
            var equation2 = new QuadraticEquation(1, 2, 1);
            var equation3 = new QuadraticEquation(1, 1, 1);


            // Act
            double result1 = equation1.GetDeterminant();
            double result2 = equation2.GetDeterminant();
            double result3 = equation3.GetDeterminant();


            // Assert
            Assert.Equal(1, result1);
            Assert.Equal(0, result2);
            Assert.Equal(-3, result3);
        }

        [Fact]
        public void Solve_ReturnsQuadraticSolutions()
        {
            // Arrange
            var equation1 = new QuadraticEquation(1, -3, 2);
            var equation2 = new QuadraticEquation(1, 2, 1);
            var equation3 = new QuadraticEquation(1, 1, 1);


            // Act
            double[] result1 = equation1.Solve();
            double[] result2 = equation2.Solve();
            double[] result3 = equation3.Solve();


            // Assert
            Assert.Equal([2,-1], result1);
            Assert.Equal([-1], result2);
            Assert.Equal([], result3);
        }

        [Fact]
        public void QuadraticEquation_ReturnsArgumentException_NotAQuadraticEquation()
        {
            // Arrange

            // Act

            // Assert
            var exception = Assert.Throws<ArgumentException>(() => 
                new QuadraticEquation(0, 2, 1).Solve());

            Assert.Equal("Not a Quadratic equation", exception.Message);
        }
    }
}
