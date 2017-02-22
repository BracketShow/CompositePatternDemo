using System.Linq;

namespace CompositePatternDemo
{
    public class OrExpressionComposite<TModel> : BooleanExpressionComposite<TModel>
    {
        public OrExpressionComposite(params ExpressionComponent<TModel>[] expressionsComponent)
        {
            foreach (var expression in expressionsComponent)
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