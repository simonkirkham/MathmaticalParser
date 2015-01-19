using MathmaticalParser;
using NUnit.Framework;


namespace UnitTests
{
    public class ParserTests
    {
        [TestCase("1a2", 3)]
        [TestCase("30a4", 34)]
        [TestCase("1a2a3", 6)]
        [TestCase("1a2a3a4", 10)]
        [TestCase("10b2", 8)]
        [TestCase("1b2b3", -4)]
        [TestCase("1c2", 2)]
        [TestCase("10c2c3", 60)]
        [TestCase("1d2", 0.5)]
        [TestCase("10d2d5", 1)]
        [TestCase("2ae3c4f", 14)]
        [TestCase("2aee3c4fc4f", 50)]
        public void WhenparsingAstring(string input, double expectedOutput)
        {
            //Given


            //When
            var output = Parser.Calculate(input);

            //Then
            Assert.That(output, Is.EqualTo(expectedOutput));
        }
    }
}
