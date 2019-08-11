using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingPatternExamples
{
    public class LambdaExpressionExamples
    {
        public void Run()
        {

            //Option #1
            //In its most explicit form, the parameter list
            //for a lambda expression looks like a normal method or anonymous method parameter list.
            Action<string> action = (string message) =>
            {
                Console.WriteLine("In delegate: {0}", message); 

            };

            action("Message");

            //Option #2 - Simplify
            //Lambda expressions shortened like this are said to have expression bodies, whereas lambda expressions using braces are said to have statement bodies.
            Action<string> action = 
                (string message) => Console.WriteLine("In delegate: {0}", message);

            //Option #3
            //For example, in the preceding code, the compiler knows that an Action<string> has a single parameter of type string,
            //so it’s capable of inferring that parameter type. When the compiler can infer the parameter type, you can omit it.
            //Therefore, our example can be shortened:
            Action<string> action = (message) => Console.WriteLine("In delegate: {0}", message);

            //Option #4
            //Finally, if the lambda expression has exactly one parameter, and that parameter’s type is inferred, the parentheses can be
            //dropped from the parameter list:
            Action<string> action = message => Console.WriteLine("In delegate: {0}", message);

            //Now let’s look at a couple of examples that return values.In each case, you’ll apply every step you can to make it shorter.         
            //    First, you’ll construct a delegate to multiply two integers together and return the result:

            //Option #1 - Longest form
            Func<int, int, int> multiply = 
                (int x, int y) => { return x * y; };

            //Option #2 - Uses expression body
            Func<int, int, int> multiply = (int x, int y) => x * y;

            //Option #3 - Infers parameter types
            //(Two parameters, so you can't remove parentheses)
            Func<int, int, int> multiply = (x, y) => x * y;

            //Next, you’ll use a delegate to take the length of a string, multiply that length by itself, and return the result:

            //Option #1 - Longest form
            Func<string, int> squareLength = (string text) => 
                { int length = text.Length; return length * length; };

            //Option #2 - Infers parameter types
            Func<string, int> squareLength = (text) => 
                { int length = text.Length; return length * length; };

            //Option #3 - Removes parans for single parameter
            Func<string, int> squareLength = text => 
                { int length = text.Length; return length * length; };


        }
    }
}