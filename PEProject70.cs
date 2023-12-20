//Wednesday 20th December 2023
//Problem 70 - Totient Permutation
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
            int maxDenominator = 10000000;
            double total = 10000000;
            long smallestNumber = 0;
            for (long i = 2; i < maxDenominator; i++) //dividing by one is not a fraction
            {
                double coprime = 1;
                List<long> fractions = p.PrimeDivisors(i);
                for (int h = 0; h < fractions.Count; h++)
                {
                    double quotient = (double)1 / fractions[h];
                    coprime *= (1 - quotient);
                }
                coprime *= i;
                ///.Distinct might work if you use two arrays maybe
                ///since .Contains HAS to be a substring
                ///
                ///Ended up choosing lists, but its very slow
                List<double> coprimeDigits = new List<double>();
                List<double> totalDigits = new List<double>();
                string totient = Convert.ToString(coprime);
                string potient = Convert.ToString(i);
               
                ///.sort?? or .orderBy might work, because then it'll do it all for me
                //for (int l = 0; l < totient.Length; l++)
                //{
                //    coprimeDigits.Add(totient[l]);
                //}
                //for (int l = 0; l < potient.Length; l++)
                //{
                //    totalDigits.Add(potient[l]);
                //}
                //if (totalDigits.Count == coprimeDigits.Count)
                //{
                //    for (int y = 0; y < totalDigits.Count; y++)
                //    {
                //        if (coprimeDigits.Contains(totalDigits[y]))
                //        {
                //           coprimeDigits.Remove(totalDigits[y]);
                //        }
                //    }
                //    if (coprimeDigits.Count == 0)
                //    {
                        if ((double)i / coprime < total)
                        {
                            total = (double)i / coprime;
                            smallestNumber = i;
                        }
                //    }
                //}                         
            }
            Console.WriteLine(total + " " + smallestNumber);
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
