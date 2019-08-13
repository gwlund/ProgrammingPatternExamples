using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace ProgrammingPatternExamples
{
    public class NullableExamples
    {
        public void Run()
        {
            Customer customer = new Customer("Customer Name");

            //If customer.Address is null, the expression customer.Address?.Country won’t try to
            //evaluate the Country property, and the result of the expression will be null.
            //The null coalescing operator then provides a default value to print.
            Console.WriteLine(customer.Address?.Country ?? "(Address unknown)");

        }
    }

    public class Customer
    {

        public Customer(string name) => Name = name;
        public string Name { get; set; }
        public Address? Address { get; set; }
    }

    public class Address
    {
        public string Country { get; set; }
    }
}