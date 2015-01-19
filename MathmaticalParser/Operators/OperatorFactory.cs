using System;
using System.Globalization;

namespace MathmaticalParser.Operators
{
    public static class OperatorFactory
    {
        public static IOperator CreateOperator(string token)
        {
            switch (token)
            {
                case "a":
                    return new AdditionOperator();
                case "b":
                    return new SubtractionOperator();
                case "c":
                    return new MultiplicationOperator();
                case "d":
                    return new DivisionOperator();                
                default:
                    throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, "Value \"{0}\" is not a valid operator", token));
            }
            
        }
    }
}
