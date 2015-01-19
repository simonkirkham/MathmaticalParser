namespace MathmaticalParser.Operators
{
    public class MultiplicationOperator : IOperator
    {
        public static string Character { get { return "c"; } }

        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}