//Thursday 21st December 2023
//Problem 42 - Coded Triangle Numbers
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
            ///Create Triangle Numbers
            List<int> triangleNumbers = new List<int>();
            for (int i = 1; i < 40; i++)
            {
                triangleNumbers.Add((1 / 2) * i * (1 + i));
            }

            Console.ReadLine();
        }
    }
}