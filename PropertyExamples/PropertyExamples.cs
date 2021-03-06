﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingPatternExamples
{
    public class PropertyExamples
    {
        //Old skole with backing field
        private int _back;

        public int Count
        {
            get
            {
                return _back;
            }
            set
            {
                _back = value;
            }
        }  
        
        
        //Read only properties
        public double X { get; }
        public double Y { get; }
        
        //Calculated property using expression body
        public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);

        // Declares a read-only property
        public int Foo => 0;
        
        // Declares a read/write public field
        public int Foo2 = 0;

        public void Run()
        {




        }
    }
}