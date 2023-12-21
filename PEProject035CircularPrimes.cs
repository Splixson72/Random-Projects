//Wednesday 13th December 2023
//Project Euler 35 - Circular Primes
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
            Program p = new Program();
            List<string> circular = new List<string>();
            string num = "";
            string circle = "";
            bool prime = true;
            for (Int64 j = 2; j < 1000000; j++) //going through a million numbers
            {
                prime = true;
                circle = Convert.ToString(j);
                num = Convert.ToString(j);
                {
                    circle = circle[circle.Length - 1] + circle.Remove(circle.Length - 1);//pushes the back to the start
                    if (!p.IsPrime(Convert.ToInt64(circle)))
                    {
                        prime = false;
                    }
                 
                } while (! (circle == num));
                if (prime == true)
                {
                    circular.Add(Convert.ToString(j)); //only the current one to avoid repeats
                    Console.WriteLine(j);
                }
            }                 
            Console.WriteLine(circular.Count);
            Console.ReadLine();
        }
        public bool IsPrime(Int64 numberGiven)
{
    Int64 number = numberGiven; //adds the current number to a independent variable so that there isn't overlap
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
