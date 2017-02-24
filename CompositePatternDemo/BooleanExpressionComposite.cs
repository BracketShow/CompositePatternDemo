using System.Collections.Generic;

namespace CompositePatternDemo
{
    public abstract class BooleanExpressionComposite<TModel> : Expression<TModel>
    {
        protected readonly List<Expression<TModel>> Expressions = new List<Expression<TModel>>();

        protected void Add(Expression<TModel> expression)
        {
            Expressions.Add(expression);
        }
    }
}