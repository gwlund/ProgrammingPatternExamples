using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingPatternExamples
{
    public class TupleExample
    {
        public void Run()
        {
            int[] values = {2, 7, 3, -5, 1, 0, 10};

            var extremes = MinMaxLinq(values);

            //Names of tuples are inferred from method signature
            Console.WriteLine(extremes.min);
            Console.WriteLine(extremes.max);

            var extermes2 = MinMaxSkeet(values);

            List<int> list = new List<int> { 5, 1, -6, 2 };

            //Tuples can have more than two elements and can be named
            var tuple1 = (list.Count, Min: list.Min(), Max: list.Max());

            //Console.WriteLine(tuple1.Count);
            Console.WriteLine(tuple1.Min); Console.WriteLine(tuple1.Max);

            var tuple2 = (x: 5, 10);
            Console.WriteLine(tuple2.x);
            Console.WriteLine(tuple2.Item1); //Second element has no name, can use position only
            Console.WriteLine(tuple2.Item2); 
            tuple2.x = 100;
            Console.WriteLine(tuple2.Item1); //First element referred by position

            //Example #2
            Point point = new Point(3, 5);

        }

        private (int min, int max) MinMaxLinq(IEnumerable<int> source)
        {
            int min = int.MaxValue, max = 0;

            min = source.Min();
            max = source.Max();

            return (min, max);

        }

        private (int min, int max) MinMaxSkeet(IEnumerable<int> source)
        {
            using (var iterator = source.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    throw new InvalidOperationException("Cannot find min/max of empty sequence");
                }

                var result = (min: iterator.Current, max: iterator.Current);

                while (iterator.MoveNext())
                {
                    result.min = Math.Min(result.min, iterator.Current);
                    result.max = Math.Max(result.max, iterator.Current);

                    //or 
                    result = (Math.Min(result.min, iterator.Current),
                        Math.Max(result.max, iterator.Current));
                }

                return result;
            }

        }
    }

    public class Point
    {

        public double X { get; set; }
        private double Y { get; set; }

        //Efficient use of tuples in constructor
        public Point(int x, int y) => (X, Y) = (x, y);

        public static bool operator ==(Point left, Point right) =>
            (left.X, left.Y) == (right.X, left.Y);

        public static bool operator !=(Point left, Point right) => !(left == right);

        //Nullable reference types only supported in C# 8.0 (.NET 4.8 = C# 7.3)
        //public override bool Equals(object? obj) =>
        //    (obj is Point otherPT)
        //        ? this == otherPT
        //        : false;

        public void SwapPoints() => (X, Y) = (Y, X);  //No temp variables needed
    }
}