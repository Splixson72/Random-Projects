//Tuesday 24th October 2023
//Special Pythagoran Triplet

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a<b<c
            //a^2 + b^2 = c^2
            //a + b + c = 1000
            //find ABC
            Double a = 0; //m^2 - n^2
            Double b = 0; //2mn
            Double c = 0; //m^2 + n^2
            //C has to be less than root 998 obv so 31
            for (int m = 0; m < 23; m++)
            {
                for (int n = 0; n < 23; n++)
                {
                    a = Math.Pow(m, 2) - Math.Pow(n, 2);
                   b = 2 * m * n;
                    c = Math.Pow(m, 2) + Math.Pow(n, 2);
                    if (a + b + c == 1000)
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                        Console.WriteLine(a * b * c);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
