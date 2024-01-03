//Wednesday 3rd January 2024
//Problem 47 - Distinct Primes Factors
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject041PandigitalPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Answer - 134043
            Program p = new Program();
            List<double> consecutives = new List<double>();
            for (int i = 0; i < 1000000; i++)
            {
                if (p.PrimeDivisors(i).Count == 4)
                {
                    consecutives.Add(i);
                    if (consecutives.Count == 4)
                    {
                        Console.WriteLine(consecutives[0]);
                    }
                }
                else { consecutives.Clear(); }
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
        public List<long> PrimeDivisors(Int64 numberToFactorise)
        {
            List<long> Prime = new List<long>();
            long j = numberToFactorise;

            for (Int64 i = 2; i <= Math.Sqrt(j); i++) //Math.Sqrt(i) is the highest a factor of i can be except itself
            {
                bool contains = false;
                if (numberToFactorise % i == 0) //this checks if it is a factor
                {
                    numberToFactorise /= i; //by continually making the number smaller, we eliminate the factors so to not repeat them
                    if (!Prime.Contains(i))
                    {
                        for (int p = 0; p < Prime.Count; p++) //because it will see something like 4, we need to see if its not already counted
                        {
                            if (i % Prime[p] == 0)
                            {
                                contains = true;
                            }
                        }
                        if (contains == false)
                        {
                            Prime.Add(i);
                        }

                    }
                    i = 2; //we start at 2 to avoid continually dividing by 1 (which is not prime)
                }
            }
            int counter = 0;
            do
            {
                counter = 0;
                for (int i = 0; i < Prime.Count; i++)
                {
                    if (numberToFactorise % Prime[i] == 0) //keep dividing the quotient by primes to get the final primes
                    {
                        numberToFactorise /= Prime[i];
                        counter += 1; ;
                    }
                }
            } while (counter != 0);
            if (numberToFactorise != 1) //add the final prime, which will always be above the square root
            {
                Prime.Add(numberToFactorise);
            }
            return Prime;
        }
    }
}
