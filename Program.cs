using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingPatternExamples.FluentInterfaces;
using ProgrammingPatternExamples.StrategyPattern;

namespace ProgrammingPatternExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fluent example
            FluentExample fluent = new FluentExample(new FluentImplementation());
            fluent.Run();

            //Strategy Pattern
            StrategyExample strategy = new StrategyExample(new ConcreteStrategyA());
            strategy.Run(); //First execute runs strategy A
            strategy.Run(); //Second execute runs strategy B

            //Adapter Pattern
            AdapterExample adapter = new AdapterExample();
            adapter.Run();

            //Builder Pattern
            BuilderExample builder = new BuilderExample();
            builder.Run();

            DecoratorExample decorator = new DecoratorExample();
            decorator.Run();

            CompositeExample composite = new CompositeExample();
            composite.Run();

            PredicatedDecoratorExample predicator = new PredicatedDecoratorExample();
            predicator.Run();

            ProfiledDecoratorExample profiler = new ProfiledDecoratorExample();
            profiler.Run();

            TupleExample tuple = new TupleExample();
            tuple.Run();

            CollectionExamples collection = new CollectionExamples();
            collection.Run();

            LambdaExpressionExamples lambda = new LambdaExpressionExamples();
            lambda.Run();
        }
    }
}
