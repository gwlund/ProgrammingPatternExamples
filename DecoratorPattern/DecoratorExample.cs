using System.ComponentModel;

namespace ProgrammingPatternExamples
{
    public class DecoratorExample
    {
        private IComponent component;

        public void Run()
        {
            component = new ConcreteComponent();
            component.Something(); //Execute the undecorated version of the method

            component = new DecoratorComponent(component);
            component.Something(); //Execute the decorated version of the method
        }
    }

    public interface IComponent
    {
        void Something();
    }

    public class ConcreteComponent : IComponent
    {
        public void Something()
        {

        }
    }

    public class DecoratorComponent : IComponent
    {
        private readonly IComponent decoratedComponent;
        public DecoratorComponent(IComponent component)
        {
            decoratedComponent = component;
        }

        public void Something()
        {
            SomethingElse();
            decoratedComponent.Something();
        }

        private void SomethingElse()
        {
            
        }
    }
}