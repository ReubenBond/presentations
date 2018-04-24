using System;
using System.Linq.Expressions;

namespace ExpressionTreeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var paramA = Expression.Parameter(typeof(int), "a");
            var paramB = Expression.Parameter(typeof(int), "b");

            var expr = Expression.Lambda<Func<int, int, int>>(
                body: Expression.Add(paramA, paramB),
                parameters: new[] {paramA, paramB});

            var compiled = expr.Compile();

            var sum = compiled(1, 2);

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}