using System;
using System.Diagnostics;

namespace ProgrammingPatternExamples
{
    public class ProfiledDecoratorExample
    {
        private IComponent component;

        public void Run()
        {
            component = new SlowComponent();
            //Implement a predicate test to determine whether to execute the something method
            component = new ProfilingComponent(component);
            component.Something();
        }
    }

    public class ProfilingComponent : IComponent
    {
        private readonly IComponent decoratedComponent;
        private readonly Stopwatch stopwatch;

        public ProfilingComponent(IComponent decoratedComponent)
        {
            this.decoratedComponent = decoratedComponent;
            stopwatch = new Stopwatch();
        }



        public void Something()
        {
            stopwatch.Start();

            decoratedComponent.Something();

            stopwatch.Stop();

            Console.WriteLine("The method took {0} seconds to complete", stopwatch.ElapsedMilliseconds / 1000);
        }
    }

    public class SlowComponent : IComponent
    {
        private readonly Random random;
        public SlowComponent()
        {
            random = new Random((int)DateTime.Now.Ticks);
        }

        public void Something()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(random.Next(i)*10);
            }
        }
    }
}