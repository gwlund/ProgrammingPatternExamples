using System;

namespace ProgrammingPatternExamples
{
    public class PredicatedDecoratorExample
    {
        private IComponent component;
        public void Run()
        {
            component = new ConcreteComponent();
            //Implement a predicate test to determine whether to execute the something method
            component = new PredicatedComponent(component, new TodayIsEvenPredicate(new DateTester()));
            component.Something();
        }
    }

    public interface IPredicate
    {
        bool Test();
    }

    public class PredicatedComponent : IComponent
    {
        private readonly IComponent decoratedComponent;
        private readonly IPredicate predicate;
        public PredicatedComponent(IComponent decoratedComponent, IPredicate predicate)
        {
            this.decoratedComponent = decoratedComponent;
            this.predicate = predicate;
        }

        public void Something()
        {
            if (predicate.Test())
                decoratedComponent.Something();
        }
    }

    public class TodayIsEvenPredicate : IPredicate
    {
        private readonly DateTester dateTester;
        public TodayIsEvenPredicate(DateTester dateTester)
        {
            this.dateTester = dateTester;
        }

        public bool Test()
        {
            return dateTester.TodayIsEvenDayOfTheMonth;
        }
    }

    public class DateTester
    {
        public bool TodayIsEvenDayOfTheMonth
        {
            get { return DateTime.Now.Day % 2 == 0; }
        }
    }
}