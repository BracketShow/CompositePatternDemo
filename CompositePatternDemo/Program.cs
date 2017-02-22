using System;

namespace CompositePatternDemo
{
    internal static class Program
    {
        private static void Main()
        {
            var model = new Model
            {
                Id = 1,
                Name = "test1",
                CreatedOn = DateTime.Parse("2017-02-10")
            };

            var expression = new AndExpression(
                new OrExpression(
                    new EqualCriteria<int>(() => model.Id, 1),
                    new EqualCriteria<string>(() => model.Name, "test1")
                ),
                new EqualCriteria<DateTime>(() => model.CreatedOn, DateTime.Parse("2017-02-10"))
            );

            Console.WriteLine("Does model:");
            Console.WriteLine(model.ToString());
            Console.WriteLine("\nMatch:");
            Console.WriteLine(expression.Display());
            Console.Write("\nAnswer:");
            Console.WriteLine(expression.Evaluate());
        }
    }
}