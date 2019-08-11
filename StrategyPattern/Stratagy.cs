using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatternExamples.StrategyPattern
{
    //From Adaptive Code:Agile coing with design patterns and SOLID principles, Second Edition
    //Gary McLean Hall
    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategyA: IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteSrategyA.Execute()");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteSrategyB.Execute()");
        }
    }

    public class StrategyExample
    {
        private readonly IStrategy strategyA = new ConcreteStrategyA();
        private readonly IStrategy strategyB = new ConcreteStrategyB();

        private IStrategy currentStrategy;

        public StrategyExample(IStrategy startStrategy)
        {
            currentStrategy = startStrategy;
        }

        public void Run()
        {
            currentStrategy.Execute();

            //swap strategy with each call
            currentStrategy = (currentStrategy == strategyA) ? strategyB : strategyA;
        }

    }
}
