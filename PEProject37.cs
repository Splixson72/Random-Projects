//Wednesday 13th December 2023
//Project Euler 37 - Trunctable Primes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PEProject7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Answer - 748317
            Program p = new Program();
            bool truntable = true;
            long trunctables = 0;
            for (Int64 j = 10; j < 1000000; j++) //must be at least two digits
            {
                if (p.IsPrime(j))
                {
                    truntable = true;
                    string trunk = Convert.ToString(j);                
                    do
                    { ///right to left
                        trunk = trunk.Remove(trunk.Length - 1);                      
                        if (trunk != "")
                        {
                            if (!p.IsPrime(Convert.ToInt64(trunk)))
                            {
                                truntable = false;
                            }
                        }
                    } while (trunk != "");
                    trunk = Convert.ToString(j); ///reset for the other way             
                   do
                    {
                        trunk = trunk.Substring(1);
                        if (trunk != "")
                        {
                            if (!p.IsPrime(Convert.ToInt64(trunk)))
                            {
                                truntable = false;
                            }
                        }                    
                    } while (trunk != "");
                    if (truntable == true)
                    {
                        trunctables += j;
                        //Console.WriteLine(j);
                        //Console.WriteLine("Total " + trunctables);
                    }
                }
            }
            Console.WriteLine("Total " + trunctables);
            Console.ReadLine();
        }
        public bool IsPrime(Int64 numberGiven)
        {
            Int64 number = numberGiven; //adds the current number to a independent variable so that there isn't overlap
            if (numberGiven==1)
            {
                return false;
            }
            for (Int64 i = 2; i <= Math.Sqrt(number); i++) //Math.Sqrt(i) is the highest a factor of i can be except itself
                                                           //i used <= to account for squarenumbers because it wouldn't be able to fully factorise them otherwise
            {
                if (number % i == 0) //this checks if it is a factor
                {
                    number = number / i; //by continually making the number smaller, we eliminate the factors so to not repeat them                                                               
                    i = 2; //we start at 2 to avoid continually dividing by 1 (which is not prime)
                }
            }
            if (number == numberGiven) //if no factors can be found, output it
            {
                return true;
            }
            return false;
        }
    }
}