using System;

namespace CompositePatternDemo
{
    internal static class Program
    {
        private static void Main()
        {

            var expression = new AndExpressionComposite<Model>(
                new OrExpressionComposite<Model>(
                    new EqualCriteriaComponent<Model, int>(m => m.Id, 1),
                    new EqualCriteriaComponent<Model, string>(m => m.Name, "test1")
                ),
                new EqualCriteriaComponent<Model, DateTime>(m => m.CreatedOn, DateTime.Parse("2017-02-10"))
            );

            var model1 = new Model
            {
                Id = 1,
                Name = "test1",
                CreatedOn = DateTime.Parse("2017-02-10")
            };
            TestModel(model1, expression);

            var model2 = new Model
            {
                Id = 1,
                Name = "test2",
                CreatedOn = DateTime.Parse("2017-02-10")
            };
            TestModel(model2, expression);

            var model3 = new Model
            {
                Id = 1,
                Name = "test2",
                CreatedOn = DateTime.Parse("2017-02-12")
            };
            TestModel(model3, expression);

        }

        private static void TestModel(Model model, ExpressionComponent<Model> expression)
        {
            Console.WriteLine("Does model:");
            Console.WriteLine(model.ToString());
            Console.WriteLine("\nMatch:");
            Console.WriteLine(expression.Display());
            Console.Write("\nAnswer:");
            Console.WriteLine(expression.Evaluate(model));
            Console.WriteLine();
        }
    }
}