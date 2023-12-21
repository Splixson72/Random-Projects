//Thursday 28th September 2023
//Project Euler 10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PEProject10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 numberToFactorise = 0;
            Int64 primeSum = 0;
            for (Int64 j = 2; j < 2000000; j++) //going through a billion numbers
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
                if (numberToFactorise == j) //if no factors can be found, add it
                {
                    Console.WriteLine(numberToFactorise);
                    primeSum += numberToFactorise;
                }
            }
            Console.WriteLine(primeSum); //OUTPUT THE RIGHT VARIABLE, IDOT
            Console.ReadLine();
        }
    }
}
