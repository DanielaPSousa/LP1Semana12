using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
       public void GetMinMax1(out double min, out double max)
        {
            min = double.MaxValue;
            max = double.MinValue;

            foreach (var num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            } 
        }
        public struct MinMax
        {
            public double Min { get; set; }
            public double Max { get; set; }
        }
    }   
}