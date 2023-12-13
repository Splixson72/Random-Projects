//Wednesday 13th Decenber 2023
//Problem 21 - Amicable Numbers
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
            int currentSum = 0;
            int total = 0;
            for (int i = 0; i < 10000; i++)
            {
                currentSum = p.FactorSum(i);
               // Console.WriteLine(currentSum + " " + i);
                if (p.FactorSum(currentSum) == i && currentSum > i) //the greater than is to make sure its only counted once
                {
                   // Console.WriteLine(currentSum + " " + i);
                    total += i;
                    total += currentSum;
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
        public int FactorSum(int input) //making subroutines is SO GOOD 
        {
            int sum = 1;
            for (int j = 2; j < input; j++) //finding all the factors
            {
                if (input % j == 0) //this checks if it is a factor
                {
                    sum += j;                 
                }
            }
            return sum;
          
        }
    }
}