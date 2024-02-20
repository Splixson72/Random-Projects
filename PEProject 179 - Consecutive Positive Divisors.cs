//20/2/2024
//Project 173 - Consecutive Positive Divisors
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace PEProject_179___Consecutive_Positive_Divisors
{ //DO THIS BUT WITH PRIME FACTORS, IM CONFIDENT IT WILL LEAD TO THE SAME RESULT
//TEST - 2, 14, 21, 26, 33, 34, 38, 44, 57, 75, 85, 86, 93, 94, 98
    internal class Program
    {
        static void Main(string[] args)
        {
            int consective;
            int totalNumbers = 0;
            int divisors1=0;
            int divisors2=0;
            for (int i = 2; i < 10000000; i++)
            {
                divisors1 = 0;
                divisors2 = 0;
                for (int j = 1; j <= i+1; j++)
                {
                    if (i%j==0)
                    {
                        divisors1 += 1;
                    }
                    if ((i + 1) % j == 0)
                    {
                        divisors2 += 1;
                    }
                }
                if (divisors1==divisors2)
                {
                    totalNumbers += 1;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(totalNumbers);
            Console.ReadLine();
        }
    }
}
