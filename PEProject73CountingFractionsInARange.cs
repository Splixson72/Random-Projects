using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEP73_CountingFractionsInARange
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            double half = (double)1 / 2;
            Console.WriteLine(half);
            double triple = (double)1 / 3;
            Console.WriteLine(triple);
            Program p = new Program();
            //7295372 Real Generated Answer with no repeated factors computed
            int maxDenominator = 12000;
            List<double> element = new List<double>();
                for (long i = 2; i <= maxDenominator; i++)
                {
                //Console.WriteLine(i);
                
                    List<long> fractions = p.PrimeDivisors(i);
                for (int j = 1; j < i; j++)
                {
                    bool divis = false;
                    for (int k = 0; k < fractions.Count; k++)
                    {
                        if (j % fractions[k] ==0 && divis ==false)
                        {
                            divis = true;
                        }
                    }
                    if (!fractions.Contains(j) && divis == false) //!element.Contains((double)j/i) && )
                    {
                        if ((double)j / i < half && (double)j / i > triple)
                        {
                            element.Add((double)j / i);
                        }
                    }
                }
                }
            Console.WriteLine(element.Count);
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
