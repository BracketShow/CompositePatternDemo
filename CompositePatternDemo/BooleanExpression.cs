using System.Collections.Generic;

namespace CompositePatternDemo
{
    public abstract class BooleanExpression : IExpression
    {
        protected readonly List<IExpression> Expressions = new List<IExpression>();

        public abstract bool Evaluate();
        public abstract string Display();

        protected void Add(IExpression expression)
        {
            Expressions.Add(expression);
        }
    }
}