using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {        
            SuperList superList = new SuperList { 3.5, 7.2, 1.8, 9.0, 2.4 };

            superList.GetMinMax1(out double min1, out double max1);
            Console.WriteLine($"GetMinMax1 - Min: {min1}, Max: {max1}");

            var minMax2 = superList.GetMinMax2();
            Console.WriteLine($"GetMinMax2 - Min: {minMax2.Min}, Max: {minMax2.Max}");

            var (min3, max3) = superList.GetMinMax3();
            Console.WriteLine($"GetMinMax3 - Min: {min3}, Max: {max3}");

            var minMax4 = superList.GetMinMax4();
            Console.WriteLine($"GetMinMax4 - Min: {minMax4.Min}, Max: {minMax4.Max}");
        }
    }
}
