//Wednesday 13th Decenber 2023
//Problem 29 - Distinct Powers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            List<double> distincts = new List<double>();
            for (int a = 2; a < 101; a++)
            {
                for (int b = 2; b < 101; b++)
                {
                    if (!distincts.Contains(p.Powers(a,b)))
                    {
                        distincts.Add(p.Powers(a, b));
                    }
                }
            }
            Console.WriteLine(distincts.Count);
            Console.ReadLine();
        }
        public double Powers(int input, int power) //making subroutines is SO GOOD 
        {        
            return Math.Pow(input,power);
          
        }
    }
}
