namespace MathmaticalParser.Operators
{
    public class AdditionOperator : IOperator
    {
        public static string Character { get { return "a"; }  }


        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}