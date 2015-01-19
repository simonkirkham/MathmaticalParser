using MathmaticalParser.Operators;
using NUnit.Framework;

namespace UnitTests.Operators
{
    public class AdditionOperatorTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(3, 4, 7)]        
        public void WhenCalculating(int inputA, int inputB, double expectedOutput)
        {
            //Given
            var additionOperator = new AdditionOperator();

            //When
            var output = additionOperator.Calculate(inputA, inputB);

            //Then
            Assert.AreEqual(expectedOutput, output);
        }
    }
}