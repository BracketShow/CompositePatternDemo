using System.Linq;

namespace CompositePatternDemo
{
    public class OrExpression : BooleanExpression
    {
        public OrExpression(params IExpression[] expressions)
        {
            foreach (var expression in expressions)
                Add(expression);
        }

        public override bool Evaluate()
        {
            return Expressions.Any(expression => expression.Evaluate());
        }

        public override string Display()
        {
            return "(" + string.Join(" or ", Expressions.Select(e => e.Display())) + ")";
        }
    }
}