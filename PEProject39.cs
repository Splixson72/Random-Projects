//Wednesday 20th December 2023
//Problem 39 - Integer Right Triangles

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
            //C has to be less than root (perimeter - 2)
            int solutions = 0;
            int maximised = 0;
            int pValue = 0;
            for (int perimeter = 12; perimeter < 1001; perimeter++)
            {
                 solutions = 0;
                for (int m = 1; m < Math.Sqrt(perimeter / 2); m++)
                {
                    for (int n = 1; n < Math.Sqrt(perimeter / 2); n++)
                    {
                        a = Math.Pow(m, 2) - Math.Pow(n, 2);
                        b = 2 * m * n;
                        c = Math.Pow(m, 2) + Math.Pow(n, 2);
                        if (a + b + c == perimeter && a>0 && b>0 && c>0) //They have to be positive
                        {
                            solutions += 1;
                            Console.WriteLine("Perimeter " + perimeter + " - " + a + " " + b + " " + c);
                        }
                    }
                }
                if (solutions > maximised)
                {
                    maximised = solutions;
                    pValue = perimeter;
                }
            }
            Console.WriteLine(maximised + " " + pValue);
            Console.ReadLine();
        }
    }
}