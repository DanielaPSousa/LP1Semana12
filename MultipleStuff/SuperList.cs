using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
       public void GetMinMax1(out double min, out double max)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("A lista está vazia.");
            }

            min = double.MaxValue;
            max = double.MinValue;

            foreach (var num in this)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            } 
        }
    }
}