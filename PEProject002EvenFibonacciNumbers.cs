// Project Euler Question 2
// Tuesday 26th September 2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 1;
            int i2 = 1;
            int i3 = 0;
            int sum = 0;
            while (i3 < 4000000)
            {
                i3 = i1 + i2;
                i1 = i2;
                i2 = i3;
                if (i3 % 2 ==0)
                {
                    sum += i3;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
