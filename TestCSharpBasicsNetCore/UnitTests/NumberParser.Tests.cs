using C_Basics.BusinessLogics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TestCSharpBasicsNetCore.UnitTests
{
    public class NumberParserTest
    {
        
        [Fact]
        public void CheckValidPhoneNumber_ReturnsSplitValues()
        {
            // Arrange
            NumberParser _numberParser = new NumberParser();
            // Act
            _numberParser.Parse("5145551234");

            // Assert
            Assert.Equal("514", _numberParser.AreaCode);
            Assert.Equal("555", _numberParser.CentralOfficeCode);
            Assert.Equal("1234", _numberParser.LineNumber);
            Assert.Equal("(514)555-1234", _numberParser.ToString());
        }

        [Fact]
        public void CheckInvalidPhoneNumber_ReturnsArgumentException()
        {
            // Arrange and Act
            var exception = Assert.Throws<ArgumentException>(() => 
                new NumberParser().Parse("514555123"));

            //Assert
            Assert.Equal("Invalid phone number", exception.Message);
        }

        
    }
}
