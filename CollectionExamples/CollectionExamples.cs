using System.Collections.Generic;

namespace ProgrammingPatternExamples
{
    public class CollectionExamples
    {
        public void Run()
        {

            var releaseYears = new Dictionary<string, int>
                {
                    { "Please please me", 1963 },
                    { "Revolver", 1966 },
                    { "Sgt. Pepper's Lonely Hearts Club Band", 1967 },
                    { "Abbey Road", 1970 }
                };

            //Use anonoymous types to populate a collection
            var players = new[]
            {
                new { Name = "Priti", Score = 6000 },
                new { Name = "Chris", Score = 7000 },
                new { Name = "Amanda", Score = 8000 },
            };
        }
    }
}