using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgrammingPatternExamples
{
    public class ExpressionBodyExamples
    {
        public void Run()
        {
            var person = new Person()
            {
                FirstName = "Gil",
                LastName = "Lund"
            };


        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public int Age { get; set; }

        public int CalcBirthYear() => DateTime.Now.Year - Age;

        public override string ToString() => $"{FirstName} {LastName}";

        public void IndentifyMe() => Console.WriteLine($"Hello: {FirstName}");

        public string FullName => $"{FirstName} {LastName}";

    }
}