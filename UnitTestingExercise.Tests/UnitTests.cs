using System;
using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test1 = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = test1.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 5, 3)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            //Act
            int actual = Calculator.Sub(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(40, 4, 160)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            //Act
            int actual = Calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(6.6, 3.0, 2.2)]//Add test data <-------
        public void DivideTest(double num1, double num2, double expected)
        {
            //Arrange

            //Act
            double actual = Calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

    }
}
