//Wednesday 27th September 2023
//Project Euler 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//What is the 10001st Prime Number
//my idea was to go to a billion numbers, and factorise them all
//if a factor can't be found, output it
//along with a counter of what place it holds
namespace PEProject7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 numberToFactorise = 0;
           int primeCounter = 0; //counts the number of primes so far
            for (Int64 j = 2; j < 1000000000; j++) //going through a billion numbers
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
                    primeCounter += 1;
                    //Console.WriteLine(numberToFactorise);
                    //Console.WriteLine(primeCounter + " " + numberToFactorise);
                }   
                if (primeCounter == 10001)
                {
                    Console.WriteLine(numberToFactorise);
                    j = 1000000000; //ends the loop
                }
            }
            Console.ReadLine();
        }
    }
}
