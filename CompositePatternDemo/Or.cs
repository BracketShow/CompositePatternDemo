using System.Linq;

namespace CompositePatternDemo
{
    public class Or<TModel> : BooleanExpressionComposite<TModel>
    {
        public Or(params Expression<TModel>[] expressions)
        {
            foreach (var expression in expressions)
                Add(expression);
        }

        public override bool Evaluate(TModel model)
        {
            return Expressions.Any(expression => expression.Evaluate(model));
        }

        public override string Display()
        {
            return "(" + string.Join(" or ", Expressions.Select(e => e.Display())) + ")";
        }
    }
}