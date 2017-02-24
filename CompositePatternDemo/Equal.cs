using System;
using System.Linq.Expressions;

namespace CompositePatternDemo
{
    public class Equal<TModel, TValue> : Expression<TModel>
    {
        private readonly System.Linq.Expressions.Expression<Func<TModel, TValue>> _eval;
        private readonly TValue _value;

        public Equal(System.Linq.Expressions.Expression<Func<TModel, TValue>> eval, TValue value)
        {
            _eval = eval;
            _value = value;
        }

        public override bool Evaluate(TModel model) => _eval.Compile().DynamicInvoke(model).Equals(_value);

        public override string Display()
        {
            var name = ((MemberExpression) _eval.Body).Member.DeclaringType?.Name + "." +
                ((MemberExpression) _eval.Body).Member.Name;
            return "(" + name + " == " + _value + ")";
        }
    }
}