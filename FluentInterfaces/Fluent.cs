using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPatternExamples.FluentInterfaces
{

    //From Adaptive Code:Agile coing with design patterns and SOLID principles, Second Edition
    //Gary McLean Hall
    public class FluentExample
    {
        private readonly IFluentInterface fluent;

        //Use dependency injection to provide implementation for interface.  "new" is a code smell
        public FluentExample(IFluentInterface f)
        {
            fluent = f;
        }

        public void Run()
        {
            //Non fluent methods must be last in the chain
            fluent.DoSomething1().DoSomething2().DoSomething3().ThisMethodIsNotFluent();
        }

    }

    public interface IFluentInterface
    {
        IFluentInterface DoSomething1();
        IFluentInterface DoSomething2();
        IFluentInterface DoSomething3();
        void ThisMethodIsNotFluent();

    }

    public class FluentImplementation : IFluentInterface
    {
        public IFluentInterface DoSomething1()
        {
            return this;
        }

        public IFluentInterface DoSomething2()
        {
            return this;
        }

        public IFluentInterface DoSomething3()
        {
            return this;
        }

        public void ThisMethodIsNotFluent()
        {

        }
    }
}
