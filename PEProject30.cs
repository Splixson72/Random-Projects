//Wednesday 13th Decenber 2023
//Problem 30 - Digit Fifth Powers
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
            double power5 = 0;
            string number = "";
            int counter = 2;
            Program p = new Program();
            do
            {
                counter += 1;
                power5 = 0;
                number = Convert.ToString(counter);
              //  Console.WriteLine(counter + " " + p.Factorial(counter));
                for (int i = 0; i < number.Length; i++)
                {
                    power5 += p.Power5(Convert.ToInt32(number[i] - '0'));
                }
              //  Console.WriteLine(counter + " " + factorial);
                if (counter == power5)
                {
                  //  Console.WriteLine("Factorial " + factorial + " " + counter);
                    total += counter;
                    Console.WriteLine(total);
                }
            } while (true);         
           Console.ReadLine();
        }
        public double Power5(int length)
        {          
            return Math.Pow(length,5);
        }
    }
}