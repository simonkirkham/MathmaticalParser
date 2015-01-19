using System;
using MathmaticalParser.Operators;
using NUnit.Framework;

namespace UnitTests.Operators
{
    public class OperatorFactoryTests
    {
        [Test]
        public void WhenCreatingAnAdditionOperator()
        {
            //Given

            //When
            var output = OperatorFactory.CreateOperator("a");

            //Then
            Assert.IsInstanceOf<AdditionOperator>(output);
        }

        [Test]
        public void WhenCreatingASubtractionOperator()
        {
            //Given

            //When
            var output = OperatorFactory.CreateOperator("b");

            //Then
            Assert.IsInstanceOf<SubtractionOperator>(output);
        }

        [Test]
        public void WhenCreatingAMultiplicationOperator()
        {
            //Given

            //When
            var output = OperatorFactory.CreateOperator("c");

            //Then
            Assert.IsInstanceOf<MultiplicationOperator>(output);
        }

        [Test]
        public void WhenCreatingADivisionOperator()
        {
            //Given

            //When
            var output = OperatorFactory.CreateOperator("d");

            //Then
            Assert.IsInstanceOf<DivisionOperator>(output);
        }

        [Test]
        public void WhenCallingWithAnIncorrectString()
        {
            //Given
            Exception exception = null;

            //When            
            try
            {
                OperatorFactory.CreateOperator("TestInput");
            }
            catch (Exception ex)
            {
                exception = ex;
            }

            //Then
            Assert.IsInstanceOf<ArgumentException>(exception);
            Assert.That(exception.Message, Is.EqualTo("Value \"TestInput\" is not a valid operator"));
        }
    }
}