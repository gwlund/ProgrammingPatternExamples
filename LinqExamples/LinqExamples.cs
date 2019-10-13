using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingPatternExamples
{
    public class LinqExamples
    {
        public void Run()
        {

            //Linq expression
            string[] words = { "keys", "coat", "laptop", "bottle" };

            IEnumerable<string> query = words.Where(word => word.Length > 4)                       
                .OrderBy(word => word)                                
                .Select(word => word.ToUpper());

            foreach (string word in query)
            {
                Console.WriteLine(word);
            }

            //Query expression
            IEnumerable<string> query0 = from word in words      //Introdcue range variable from clause
                                        where word.Length > 4   //Use the range variable in the following clauses
                                        orderby word
                                        select word.ToUpper();

            //Two range variables
            //Query expression
            IEnumerable<string> query1 = from word in words //Introdcue range variable from clause
                let length = word.Length
                where length > 4 //Use the range variable in the following clauses
                orderby length
                select string.Format("{0}: {1}", length, word.ToUpper());

            //Filtering options
            //Query expression
            IEnumerable<string> query2 = from word in words      //Introdcue range variable from clause
                                        where word.Length > 4   //Use the range variable in the following clauses
                                        select word;

            //Simplier syntax
            IEnumerable<string> query3 = words.Where(word => word.Length > 4);



        }
    }
}