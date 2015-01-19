using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;
using MathmaticalParser.Operators;

namespace MathmaticalParser
{
    public class Parser
    {
        private static readonly Collection<string> Operators = new Collection<string>
        {
            AdditionOperator.Character,
            SubtractionOperator.Character,
            MultiplicationOperator.Character,
            DivisionOperator.Character
        };

        private const string OpeningBracket = "e";
        private const string ClosingBracket = "f";

        public static double Calculate(string expression)
        {
            if (DoesExpressionContainBrackets(expression))
            {
                expression = SubstituteSubExpression(expression);
            }

            return EvaluateSimpleExpression(expression);
        }

        private static string SubstituteSubExpression(string expression)
        {
            var startIndex = expression.IndexOf(OpeningBracket, StringComparison.Ordinal) + 1;
            var length = expression.LastIndexOf(ClosingBracket, StringComparison.Ordinal) - startIndex;

            var subExpression = expression.Substring(startIndex, length);

            var subTotal = Calculate(subExpression);

            expression =
                expression.Replace(String.Format(CultureInfo.CurrentCulture, "{0}{1}{2}", OpeningBracket,
                    subExpression, ClosingBracket), subTotal.ToString(CultureInfo.InvariantCulture));

            return expression;
        }

        private static double EvaluateSimpleExpression(string expression)
        {
            double total = GetNextNumber(expression, 0);

            for (var i = 0; i < expression.Length - 1; i++)
            {
                var token = expression.Substring(i, 1);

                if (Operators.Contains(token))
                {
                    //If the OperatorFactory was doing anything more complicated it would need to passed in via dependency injection and stubbed.
                    //As it is this class is still easy to test so I have not done this.
                    var calculationOperator = OperatorFactory.CreateOperator(token);

                    total = calculationOperator.Calculate(total, GetNextNumber(expression, i + 1));
                }
            }

            return total;
        }

        private static bool DoesExpressionContainBrackets(string expression)
        {
            return expression.Contains(OpeningBracket) && expression.Contains(ClosingBracket);
        }


        private static int GetNextNumber(string expression, int position)
        {
            var numberStringBuilder = new StringBuilder();

            var character = expression.Substring(position, 1);
            int notUsed;

            while (int.TryParse(character, out notUsed))
            {
                numberStringBuilder.Append(character);
                position ++;
                character = expression.Length > position ? expression.Substring(position, 1) : "";
            }

            return int.Parse(numberStringBuilder.ToString());
        }
    }
}