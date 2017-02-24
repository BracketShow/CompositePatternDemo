using System.Linq;

namespace CompositePatternDemo
{
    public class And<TModel> : BooleanExpressionComposite<TModel>
    {
        public And(params Expression<TModel>[] expressions)
        {
            foreach (var expression in expressions)
                Add(expression);
        }

        public override bool Evaluate(TModel model)
        {
            return Expressions.All(expression => expression.Evaluate(model));
        }

        public override string Display()
        {
            return "(" + string.Join(" and ", Expressions.Select(e => e.Display())) + ")";
        }
    }
}