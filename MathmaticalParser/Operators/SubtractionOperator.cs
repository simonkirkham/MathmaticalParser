namespace MathmaticalParser.Operators
{
    public class SubtractionOperator : IOperator
    {
        public static string Character { get { return "b"; } }

        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}