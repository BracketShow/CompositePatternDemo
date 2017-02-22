using System;
using System.Linq.Expressions;

namespace CompositePatternDemo
{
    public class EqualCriteria<TValue> : IExpression
    {
        private readonly Expression<Func<TValue>> _eval;
        private readonly TValue _value;

        public EqualCriteria(Expression<Func<TValue>> eval, TValue value)
        {
            _eval = eval;
            _value = value;
        }

        public bool Evaluate() => _eval.Compile().Invoke().Equals(_value);

        public string Display()
        {
            var name = ((MemberExpression) _eval.Body).Member.DeclaringType?.Name + "." +
                ((MemberExpression) _eval.Body).Member.Name;
            return "(" + name + " == " + _value + ")";
        }
    }
}