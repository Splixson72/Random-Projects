//Tuesday 26th September 2023
//Project Euler 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 numberToFactorise = 600851475143;
            //Int64 numberToFactorise = 13195;
            for (Int64 i = 2; i < Math.Sqrt(numberToFactorise); i++) //Math.Sqrt(i) is the highest a factor of i can be except itself
            {
                if (numberToFactorise % i == 0) //this checks if it is a factor
                {
                    numberToFactorise = numberToFactorise / i; //by continually making the number smaller, we eliminate the factors so to not repeat them
                    Console.WriteLine(i);
                    Console.WriteLine(numberToFactorise);
                    i = 2; //we start at 2 to avoid continually dividing by 1 (which is not prime)
                }
            }
            Console.ReadLine();
        }
    }
}
