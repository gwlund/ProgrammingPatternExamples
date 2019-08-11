using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgrammingPatternExamples
{
    public class CompositeExample
    {
        private IComponent component;
        public void Run()
        {
            var composite = new CompositeComponent();

            //Allow many component objects to be acted on at once with one call to Something
            composite.AddComponent(new Leaf());
            composite.AddComponent(new LeafType2());
            composite.AddComponent(new LeafType3());

            component = composite;
            component.Something();
        }
    }

    public class LeafType3 : IComponent
    {
        public void Something()
        {
            
        }
    }

    public class LeafType2 : IComponent
    {
        public void Something()
        {
            
        }
    }

    public class Leaf : IComponent
    {
        public void Something()
        {
            
        }
    }

    public class CompositeComponent : IComponent
    {
        private ICollection<IComponent> children;

        public CompositeComponent()
        {
            children = new List<IComponent>();
        }
        public void AddComponent(IComponent component)
        {
            children.Add(component);
        }

        public void Something()
        {
            foreach (var child in children)
            {
                child.Something();
            }
        }
    }
}