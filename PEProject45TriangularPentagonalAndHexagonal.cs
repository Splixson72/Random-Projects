//Thursday 21st December 2023
//Problem 45 - Triangular, Pentagonal, and Hexagonal
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
            //Answer - 1533776805
            ///Create Triangle Numbers
            List<double> triangle = new List<double>();
            for (double i = 1; i < 100000; i++)
            {
                double currentTri = i * (i + 1);
                currentTri /= 2;
                triangle.Add(currentTri);
            }
            ///Create pentagon Numbers
            List<double> pentagon = new List<double>();
            for (double i = 1; i < 100000; i++)
            {
                double currentPent = i * ((3 * i) - 1);
                currentPent /= 2;
                pentagon.Add(currentPent);
            }
            ///Create Hexagon Numbers
            List<double> hexagon = new List<double>();
            for (double i = 1; i < 100000; i++)
            {
                double currentHex = i * ((2 * i) - 1);              
                hexagon.Add(currentHex);
            }
            ///Check them all
            for (int i = 0; i < triangle.Count; i++)
            {
                if (hexagon.Contains(triangle[i]) && pentagon.Contains(triangle[i]))
                {
                    Console.WriteLine(triangle[i]);
                }
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}