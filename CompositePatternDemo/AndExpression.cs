using System.Linq;

namespace CompositePatternDemo
{
    public class AndExpression : BooleanExpression
    {
        public AndExpression(params IExpression[] expressions)
        {
            foreach (var expression in expressions)
                Add(expression);
        }

        public override bool Evaluate()
        {
            return Expressions.All(expression => expression.Evaluate());
        }

        public override string Display()
        {
            return "(" + string.Join(" and ", Expressions.Select(e => e.Display())) + ")";
        }
    }
}