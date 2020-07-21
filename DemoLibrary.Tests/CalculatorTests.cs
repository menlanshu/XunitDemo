using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate_Fact()
        {
            // Arrange
            double expected = 5;

            // Act
            double actual = Calculator.Add(3, 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21,5.25,26.25)]
        [InlineData(double.MaxValue,5,double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate_Theory(double x, double y, double expected)
        {
            // Arrange
            // Expected value assigned by inline data decorator

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(21, 3, 7)]
        public void Divide_SimpleValuesShouldCalculate_Theory(double x, double y, double expected)
        {
            // Arrange
            // Expected value assigned by inline data decorator

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero_Fact()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(10, 0);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
