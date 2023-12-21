//Wednesday 20th December 2023 + Thursday 21st December 2023
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
            //Answer - 840
            int solutions = 0;
            int maximised = 0;
            int pValue = 0;
            bool divisible = false;
            List<int> sums = new List<int>();
            for (int perimeter = 12; perimeter < 1001; perimeter++)
            {
                for (int m = 1; m < perimeter; m++)
                {
                    for (int n = 1; n < perimeter; n++)
                    {
                        divisible = false;
                        double a = Math.Pow(m, 2) - Math.Pow(n, 2); ///Euclid's formaulae
                        double b = 2 * m * n;
                        double c = Math.Pow(m, 2) + Math.Pow(n, 2);
                        if (a + b + c == perimeter && a > 0 && b > 0 && c > 0) //They have to be positive
                        {
                            for (int i = 0; i < sums.Count; i++)
                            {
                                if (perimeter % sums[i] == 0) ///check that we're not counting multiples
                                {
                                    divisible = true;
                                }
                            }
                            if (divisible == false)
                            {
                                sums.Add(perimeter);                                
                            }
                        }
                    }
                }
            }
            for (int i = 0; i <= sums[i]; i++)
            {
                solutions = 0;
                for (int j = 0; j < sums.Count; j++)
                {
                    if (sums[i] % sums[j] == 0)
                    {
                        solutions += 1;
                    }
                }               
                if (solutions > maximised)
                {
                    maximised = solutions;
                    pValue = sums[i];
                }
            }
            Console.WriteLine(pValue + " provides " + maximised + " solutions.");
            Console.ReadLine();
        }
    }
}
