using System.Linq;

namespace CompositePatternDemo
{
    public class AndExpressionComposite<TModel> : BooleanExpressionComposite<TModel>
    {
        public AndExpressionComposite(params ExpressionComponent<TModel>[] expressionsComponent)
        {
            foreach (var expression in expressionsComponent)
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