using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgrammingPatternExamples
{
    public class StringExamples
    {
        public void Run()
        {

            string name = "gil";

            //String literal
            string hello = $"Hello, {name}";

            decimal price = 95.25m;
            decimal tip = price * 0.2m;

            //String literal with formatting
            Console.WriteLine($"Price: {price,9:C}");
            Console.WriteLine($"Tip:   {tip,9:C}");
            Console.WriteLine($"Total: {price + tip,9:C}");

            int x = 10;
            int y = 20;
            string text = $"x={x}, y={y}";
            Console.WriteLine(text);

            //Verabtim strings.  No escape needed for folder
            string filename = @"C:\Windows";

            string sql = @"                                        
                SELECT City, ZipCode
                FROM Address
                WHERE Country = 'US'";

            Regex lettersDotDigits = new Regex(@"[a-z]+\.\d+");
            string file = @"c:\users\skeet\Test\Test.cs";


        }
    }
}