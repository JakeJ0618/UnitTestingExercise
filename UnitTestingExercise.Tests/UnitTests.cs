using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5,2,7,14)]
        [InlineData(6, 4, 8, 18)]
        [InlineData(4,7,3,14)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator tester = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = tester.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,0)]//Add test data <-------
        [InlineData(4,3,1)]
        [InlineData(7,5,2)]
        [InlineData(8,6,2)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new Calculator();
            //Act
            var actual = tester.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,4,16)]//Add test data <-------
        [InlineData(2,7,14)]
        [InlineData(3,6,18)]
        [InlineData(3,5,15)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var tester = new Calculator();
            //Act
            var actual = tester.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6,2,3)]//Add test data <-------
        [InlineData(10,5,2)]
        [InlineData(15,5,3)]
        [InlineData(4,4,1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new Calculator();
            //Act
            var actual = tester.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
