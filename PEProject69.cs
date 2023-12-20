//Wednesday 20th December 2023
//Problem 69 - Totient Maximum
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
            //Answer: 510510
            Program p = new Program();
            long maxDenominator = 1000000;
            double maximum = 0;
            long biggestNumber = 0;
            for (long i = 2; i <= maxDenominator; i++) ///dividing by one is not a fraction
            {
                double coprime = 1;
                List<long> fractions = p.PrimeDivisors(i);
                for (int h = 0; h < fractions.Count; h++)
                {
                    double quotient = (double)1 / fractions[h];
                    coprime *= (1 - quotient);
                }
                coprime *= i;
                if (i / coprime > maximum)
                {
                    maximum = i / coprime;
                    biggestNumber = i;
                    Console.WriteLine(maximum + " " + biggestNumber);
                    ///6 was generated so its a good start
                }
            }
            Console.WriteLine(maximum + " " + biggestNumber);
            Console.ReadLine();
        }
            public List<long> PrimeDivisors(Int64 numberToFactorise)
            {
                List<long> Prime = new List<long>();
                long j = numberToFactorise;

                for (Int64 i = 2; i <= Math.Sqrt(j); i++) ///Math.Sqrt(i) is the highest a factor of i can be except itself
                {
                    bool contains = false;
                    if (numberToFactorise % i == 0) ///this checks if it is a factor
                    {
                        numberToFactorise /= i; ///by continually making the number smaller, we eliminate the factors so to not repeat them
                        if (!Prime.Contains(i))
                        {
                            for (int p = 0; p < Prime.Count; p++) ///because it will see something like 4, we need to see if its not already counted
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
                        i = 2; ///we start at 2 to avoid continually dividing by 1 (which is not prime)
                    }
                }
                int counter = 0;
                do
                {
                    counter = 0;
                    for (int i = 0; i < Prime.Count; i++)
                    {
                        if (numberToFactorise % Prime[i] == 0) ///keep dividing the quotient by primes to get the final primes
                        {
                            numberToFactorise /= Prime[i];
                            counter += 1; ;
                        }
                    }
                } while (counter != 0);
                if (numberToFactorise != 1) ///add the final prime, which will always be above the square root
                {
                    Prime.Add(numberToFactorise);
                }
                return Prime;
            }
        
    }
}