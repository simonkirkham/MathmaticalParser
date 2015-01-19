using MathmaticalParser.Operators;
using NUnit.Framework;

namespace UnitTests.Operators
{
    public class MultiplicationOperatorTests
    {
        [TestCase(2, 4, 8)]
        [TestCase(2, 3, 6)]
        public void WhenCalculating(int inputA, int inputB, double expectedOutput)
        {
            //Given
            var additionOperator = new MultiplicationOperator();

            //When
            var output = additionOperator.Calculate(inputA, inputB);

            //Then
            Assert.AreEqual(expectedOutput, output);
        }
    }
}