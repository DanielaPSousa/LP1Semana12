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
        public MinMax GetMinMax2()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return new MinMax { Min = min, Max = max };
        }
        public (double min, double max) GetMinMax3()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return (min, max);
        }
        public (double Min, double Max) GetMinMax4()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return (Min: min, Max: max);
        }
    }   
}