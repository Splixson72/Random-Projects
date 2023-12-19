//Tuesday 19th December 2023
//Problem 72 - Counting Fractions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //297636497331 Generated answer for D = 1000000
            int maxDenominator = 8;
            double total = 0;
            for (long i = 2; i <= maxDenominator; i++) //dividing by one is not a fraction
            {
                double coprime = 1;
                List<long> fractions = p.PrimeDivisors(i);
                //    Console.WriteLine(i + " " + fractions.Count);
                Console.WriteLine("Factors of " + i);
                for (int m = 0; m < fractions.Count; m++) //OUTPUT ALL FACTORS FOR CHECKING
                {
                    Console.WriteLine(fractions[m]);
                }
                for (int h = 0; h < fractions.Count; h++)
                {
                    double quotient = (double)1 / fractions[h];
                    coprime *= (1 - quotient);
           
                }
                coprime *= i;
                total += coprime;
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
        public List<long> PrimeDivisors(Int64 numberToFactorise)
        {
            List<long> Prime = new List<long>();
            long j = numberToFactorise;
            for (Int64 i = 2; i <= Math.Sqrt(j); i++) //Math.Sqrt(i) is the highest a factor of i can be except itself
            {
                if (numberToFactorise % i == 0) //this checks if it is a factor
                {
                    numberToFactorise /= i; //by continually making the number smaller, we eliminate the factors so to not repeat them
                    if (!Prime.Contains(i))
                    {
                        Prime.Add(i);
                    }
                    i = 2; //we start at 2 to avoid continually dividing by 1 (which is not prime)
                }
            }
            //long k = numberToFactorise;
            //do
            //{         
            //    for (int i = 0; i < Prime.Count; i++)
            //    {
            //        if (numberToFactorise % Prime[i] == 0)
            //        {
            //            numberToFactorise /= Prime[i];
            //            Console.WriteLine("divided by " + Prime[i]);
            //           // final = false;
            //        }
            //    }
            //} while ((k==numberToFactorise) || (numberToFactorise!=1));        

            if (numberToFactorise==j)
            {
                Prime.Add(numberToFactorise);
            }      
           
            return Prime;
        }   
    }
}
