using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem351
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 sum = 0;
            Int64 end = 100000001;
            for (Int64 i = 2; i < end; i++)
            {
                double coprime = 1;
                List<long> fractions = PrimeDivisors(i);
                for (int h = 0; h < fractions.Count; h++)
                {
                    double quotient = (double)1 / fractions[h];
                    coprime *= (1 - quotient);
                }
                coprime *= i;
                Console.WriteLine(i + " " + (i - 1 - Convert.ToInt64(coprime)));
                sum += i - 1 - Convert.ToInt64(coprime);                               
            }
            sum *= 6;
            sum += 6 * (end - 2);
            
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    
     static List<long> PrimeDivisors(Int64 numberToFactorise)
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
