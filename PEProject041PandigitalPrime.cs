//Wednesday 3rd January 2024
//Problem 41 - Pandigital Prime
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
            ///Answer - 7652413
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //Generate a list of primes from 2 to 987654321 (9 pandigital)
            //the trick is that there are no 9 digit pandigital primes, since having 1-9 means its divisible by 3 
            //same with 8 for similar reasons
            List<string> primeList = new List<string>();         
            for (Int64 j = 2; j < 7654321; j++) //going all the way to the max number
            {
                Int64 numberToFactorise = j; //adds the current number to a independent variable so that there isn't overlap
                string currentNumber = Convert.ToString(j);
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
                    if (Convert.ToString(j).Distinct().Count() == Convert.ToString(j).Length && !Convert.ToString(j).Contains('0')) //ensures that there are no multiple digits or 0s
                    {
                        //Now find which are pandigital
                            bool pandigital = true;
                            for (int m = 0; m < currentNumber.Length; m++) //it should contain all the digits up to its length
                            {
                                if (!currentNumber.Contains(digits[m]))
                                {
                                    pandigital = false;
                                }
                            }
                            if (pandigital == true) //outputs them in increasing size for a benchmark
                            {
                                Console.WriteLine(j); //2143 should be output at some point
                            }
                    }          
                }         
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
