namespace CompositePatternDemo
{
    public abstract class ExpressionComponent<TModel>
    {
        public abstract bool Evaluate(TModel model);
        public abstract string Display();
    }
}