namespace MathmaticalParser.Operators
{
    public class DivisionOperator : IOperator
    {
        public static string Character { get { return "d"; } }

        public double Calculate(double a, double b)
        {
            //Casting to double is required to stop loss of fraction when dividing two integers.
            return (double)a / b;
        }
    }
}