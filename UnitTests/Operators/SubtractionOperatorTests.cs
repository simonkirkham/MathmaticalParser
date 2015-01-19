using MathmaticalParser.Operators;
using NUnit.Framework;

namespace UnitTests.Operators
{
    public class SubtractionOperatorTests
    {
        [TestCase(2, 1, 1)]
        [TestCase(4, 2, 2)]
        public void WhenCalculating(int inputA, int inputB, double expectedOutput)
        {
            //Given
            var additionOperator = new SubtractionOperator();

            //When
            var output = additionOperator.Calculate(inputA, inputB);

            //Then
            Assert.AreEqual(expectedOutput, output);
        }
    }
}