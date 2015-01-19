using MathmaticalParser.Operators;
using NUnit.Framework;

namespace UnitTests.Operators
{
    public class DivisionOperatorTests
    {
        [TestCase(10, 4, 2.5)]
        [TestCase(3, 3, 1)]
        public void WhenCalculating(int inputA, int inputB, double expectedOutput)
        {
            //Given
            var additionOperator = new DivisionOperator();

            //When
            var output = additionOperator.Calculate(inputA, inputB);

            //Then
            Assert.AreEqual(expectedOutput, output);
        }
    }
}