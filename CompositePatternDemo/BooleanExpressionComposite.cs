using System.Collections.Generic;

namespace CompositePatternDemo
{
    public abstract class BooleanExpressionComposite<TModel> : ExpressionComponent<TModel>
    {
        protected readonly List<ExpressionComponent<TModel>> Expressions = new List<ExpressionComponent<TModel>>();

        protected void Add(ExpressionComponent<TModel> expressionComponent)
        {
            Expressions.Add(expressionComponent);
        }
    }
}