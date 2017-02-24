using System;

namespace CompositePatternDemo
{
    internal static class Program
    {
        private static Expression<Model> _expression;

        private static void Main()
        {
            _expression = new And<Model>(
                new Or<Model>(
                    new Equal<Model, int>(m => m.Id, 1),
                    new Equal<Model, string>(m => m.Name, "test1")
                ),
                new Equal<Model, DateTime>(m => m.CreatedOn, DateTime.Parse("2017-02-10"))
            );

            Console.WriteLine("Matching expression:");
            Console.WriteLine(_expression.Display());

            var model1 = new Model
            {
                Id = 1,
                Name = "test1",
                CreatedOn = DateTime.Parse("2017-02-10")
            };
            TestModel(model1, _expression);

            var model2 = new Model
            {
                Id = 1,
                Name = "test2",
                CreatedOn = DateTime.Parse("2017-02-10")
            };
            TestModel(model2, _expression);

            var model3 = new Model
            {
                Id = 1,
                Name = "test2",
                CreatedOn = DateTime.Parse("2017-02-12")
            };
            TestModel(model3, _expression);
        }

        private static void TestModel(Model model, Expression<Model> expression)
        {
            Console.WriteLine();
            Console.WriteLine("Matching:");
            Console.WriteLine(model.ToString());
            Console.WriteLine();
            Console.Write("Answer: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(expression.Evaluate(model));
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}