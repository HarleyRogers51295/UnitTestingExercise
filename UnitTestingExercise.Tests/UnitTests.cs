using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Addition(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 15)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 50)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 10, 5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

       
    }
}
