//Wednesday 13th Decenber 2023
//Problem 34 - Digit Factorials
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int factorial = 0;
            string number = "";
            int counter = 2;
            Program p = new Program();
            do
            {
                counter += 1;
                factorial = 0;
                number = Convert.ToString(counter);
              //  Console.WriteLine(counter + " " + p.Factorial(counter));
                for (int i = 0; i < number.Length; i++)
                {
                    factorial += p.Factorial(Convert.ToInt32(number[i] - '0'));
                }
              //  Console.WriteLine(counter + " " + factorial);
                if (counter == factorial)
                {
                  //  Console.WriteLine("Factorial " + factorial + " " + counter);
                    total += counter;
                    Console.WriteLine(total);
                }
            } while (true);         
           Console.ReadLine();
        }
        public int Factorial(int length)
        {
            int combinations = 1;
            if (length == 0)
            {
                return 1;
            }
            do
            {
                combinations *= length;
                length -= 1;
            } while (length > 1);
            return combinations;
        }
    }
}