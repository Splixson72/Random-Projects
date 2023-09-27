//Wednesday 27th September 2023
//Project Euler 6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject6
    //the sum of all the numbers between 1 and n is n(n+1)/2 (which can then be squared easily)
//the sum of all the squares is trickier, but shouldn't be hard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SumSquare = 0;
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i * i); //don't use ^2, although it usually means squared, it does
                                          //something different in C#, idk what yet
                SumSquare += i * i;
            }
            Console.WriteLine(SumSquare);
            int squareSum = (100 * 101 / 2) * (100 * 101 / 2);
            Console.WriteLine(squareSum);
            Console.WriteLine(squareSum - SumSquare);
            Console.ReadLine();
        }
    }
}