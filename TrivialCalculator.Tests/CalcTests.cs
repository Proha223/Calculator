using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace TrivialCalculator.Tests
{
    [TestClass]
    public class CalcTests
    {
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(-1, 4, 3)]
        public void Add(double a, double b, double expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var actual = calc.Add(a, b);

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [DataRow(1, 2, -1)]
        [DataRow(2, 2, 0)]
        [DataRow(3, 2, 1)]
        public void Substract(double a, double b, double expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var actual = calc.Substract(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(9, 3, 27)]
        [DataRow(3, 3, 9)]
        [DataRow(-3, -3, 9)]
        public void Multiply(double a, double b, double expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var actual = calc.Multiply(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(9, 3, 3)]
        [DataRow(3, 3, 1)]
        [DataRow(8, 2, 4)]
        public void Divide(double a, double b, double expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var actual = calc.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(4, 2)]
        [DataRow(9, 3)]
        [DataRow(25, 5)]
        [DataRow(16, 4)]
        public void SquareRoot(double d, double expected)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var actual = calc.SquareRoot(d);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}