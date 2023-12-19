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
            int maxDenominator = 1000000;
            List<double> fractions = new List<double>();
            List<double> primeList = new List<double>();
            double numberToFactorise = 0;
            primeList.Add(1);
            for (Int64 j = 2; j < maxDenominator; j++) //going through a billion numbers
            {
                numberToFactorise = j; //adds the current number to a independent variable so that there isn't overlap
                for (Int64 i = 2; i <= Math.Sqrt(numberToFactorise); i++) //Math.Sqrt(i) is the highest a factor of i can be except itself
                                                                          //i used <= to account for squarenumbers because it wouldn't be able to fully factorise them otherwise
                {
                    if (numberToFactorise % i == 0) //this checks if it is a factor
                    {
                        numberToFactorise = numberToFactorise / i; //by continually making the number smaller, we eliminate the factors so to not repeat them                                                               
                        i = 2; //we start at 2 to avoid continually dividing by 1 (which is not prime)
                    }
                }
                if (numberToFactorise == j) //if no factors can be found, output it
                {
                    primeList.Add(numberToFactorise);
                    //Console.WriteLine(numberToFactorise);
                    //Console.WriteLine(primeCounter + " " + numberToFactorise);
                }
            }
            Console.WriteLine("ALL PRIMES FOUND");
                for (double i = 2; i <= maxDenominator; i++) //dividing by one is not a fraction
            {
               Console.WriteLine(i);
                for (double j = 1; j < maxDenominator; j++) //dividing 0 is not a fraction
                {
                    if (primeList.Contains(j) || primeList.Contains(i))
                    {
                        if (!fractions.Contains(j / i) && j < i)
                        {
                            fractions.Add(j / i);
                            Console.WriteLine(j + " " + i);
                            //  Console.WriteLine(j/i);
                        }
                    }
                    if (j<i)
                    {
                        j = maxDenominator - 1;
                    }
                }
            }
            Console.WriteLine(fractions.Count);
            Console.ReadLine();
        }
        //public bool IsItPrime(double number)
        //{
        //    Int64 numberToFactorise = Convert.ToInt64(number);
        //    for (Int64 i = 2; i < Math.Sqrt(numberToFactorise); i++) //Math.Sqrt(i) is the highest a factor of i can be except itself
        //    {
        //        if (numberToFactorise % i == 0) //this checks if it is a factor
        //        {
        //            numberToFactorise /= i;
        //        }
        //        if (numberToFactorise == number || numberToFactorise==1) //if no factors can be found, return true
        //        {
        //            return true;
        //        }            
        //    }
        //    return false;
        //}
    }
}
