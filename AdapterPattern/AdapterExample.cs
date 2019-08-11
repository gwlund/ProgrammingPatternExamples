using System;

namespace ProgrammingPatternExamples
{
    public class AdapterExample
    {
        public void Run()
        {
            //Goal is to call target methodB via the adapter methodA
            IExpectedInterface adapter = new Adapter(new TargetClass());
            adapter.MethodA();

        }
    }

    public interface IExpectedInterface
    {
        void MethodA();
    }

    public class Adapter : IExpectedInterface
    {
        private TargetClass target;
        public Adapter(TargetClass target)
        {
            this.target = target;
        }

        public void MethodA()
        {
            target.MethodB();
        }
    }

    public class TargetClass
    {

        public void MethodB()
        {
            Console.WriteLine("Called Target MethodB");

        }
    }
}