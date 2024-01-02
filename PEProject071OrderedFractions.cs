//Tuesday 2nd January 2024
//Problem 71 - Ordered Fractions
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject071OrderedFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Find the biggest fraction less than 3/7th         
            ///Easy take the Math.Floor of 3/7th of every number, and see what comes closest
            //Answer - 4258570
            double numerator = 0;
            double ordered = 0;
            double LIMIT = (double)3 / 7;
            Console.WriteLine(LIMIT);
            for (int i = 0; i <= 1000000; i++)
            {
                double fraction = Math.Truncate(LIMIT * i);
                if (LIMIT*i > ordered)
                {
                   
                    ordered = (double)fraction / i;
                    numerator = fraction;
                }
            }
            Console.WriteLine(numerator);
            Console.ReadLine();
        }
    }
}
