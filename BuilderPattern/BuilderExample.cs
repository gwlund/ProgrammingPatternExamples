using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ProgrammingPatternExamples
{
    public class BuilderExample
    {
        public void Run()
        {
            var product = new Product();
            var builder = new ConcreteBuilder(product);
            product = builder.SetProductName("My Product")
                   .SetInitialProductValue((decimal) 30.00f).Build();

            Console.WriteLine("Product Name: {0}", product.Name );
            Console.WriteLine("Product Initial Value {0}", product.InitialValue);

            //Example #2 - https://learning.oreilly.com/library/view/design-patterns-in/9781484243664/html/476082_1_En_3_Chapter.xhtml
            //HtmlElement root = HtmlElement
            //    .Create("ul")
            //    .AddChildFluent("li", "hello")
            //    .AddChildFluent("li", "world");

            //Console.WriteLine(root);

        }
    }

    public class HtmlElement
    {
        protected string Name, Text;

        protected List<HtmlElement> Elements = new List<HtmlElement>();
        protected const int indentSize = 2;  
        
        // hide the constructors!
        protected HtmlElement() {}
        protected HtmlElement(string name, string text)  {    Name = name;    Text = text;  }  
        
        // factory method
        //public static HtmlBuilder Create(string name) => new HtmlBuilder(name);

    }

    public class HtmlBuilder
    {
        protected readonly string rootName;
        //protected HtmlElement root = new HtmlElement();

        //public static implicit operator HtmlElement(HtmlBuilder builder)
        //{
        //    return builder.root;
        //}

        //public HtmlBuilder(string rootName) { this.rootName = rootName; root.Name = rootName; }

        //public HtmlBuilder AddChildFluent(string childName, string childText)
        //{
        //    var e = new HtmlElement(childName, childText);
        //    root.Elements.Add(e);
        //    return this;
        //}

        //public override string ToString() => root.ToString();

    }

    public interface IBuilder
    {
        Product Build();
    }

    public class ConcreteBuilder : IBuilder
    {
        private readonly Product product;
        public ConcreteBuilder(Product product)
        {
            this.product = product;
        }

        public ConcreteBuilder SetProductName(string name)
        {
            product.Name = name;
            return this;
        }

        public ConcreteBuilder SetInitialProductValue(decimal value)
        {
            product.InitialValue = value;
            return this;
        }

        public Product Build()
        {
            return product;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal InitialValue { get; set; }
    }
}