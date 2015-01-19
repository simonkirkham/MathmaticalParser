using MathmaticalParser;
using NUnit.Framework;

namespace AcceptanceTests
{    
    public class ParserTests
    {
        [TestCase("3a2c4", 20)]
        [TestCase("32a2d2", 17)]
        [TestCase("500a10b66c32", 14208)]
        [TestCase("3ae4c66fb32", 235)]
        [TestCase("3c4d2aee2a4c41fc4f", 990)]        
        public void WhenParsingAnExpression(string input, int expectedOuput)
        {
            //Given

            //When
            var output = Parser.Calculate(input);

            //Then
            Assert.AreEqual(expectedOuput, output);
        }
    }
}
