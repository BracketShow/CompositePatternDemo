namespace CompositePatternDemo
{
    public abstract class Expression<TModel>
    {
        public abstract bool Evaluate(TModel model);
        public abstract string Display();
    }
}