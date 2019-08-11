using System;
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

        }
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