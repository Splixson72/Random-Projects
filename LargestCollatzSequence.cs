//Friday 20th October 2023
//Project Euler 14 - Largest Collatz Sequence
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCollatzSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 collatz = 0; //BIG Numbers
            Int64 counter = 1;
            Int64 high = 1;
            Int64 numero = 0;
            for (int i = 0; i < 1000000; i++)
            {
                //if (i % 1000 == 0)
                //{
                //    Console.WriteLine(i);
                //}
                collatz = i;
                do
                {
                if (collatz % 2 == 0)
                {
                    collatz = collatz / 2;
                    //Console.WriteLine(collatz);
                    counter += 1;
                }
                else
                {
                        collatz = (3 * collatz) + 1;
                    //Console.WriteLine(collatz);
                    counter += 1;
                    }
                } while (collatz > 1);
                if (counter > high)
                {
                    numero = i;
                    high = counter;
                    counter = 1;
                }
            counter = 1;
          }

            Console.WriteLine(numero);
            Console.WriteLine(high);
            Console.ReadLine();
        }
    }
}
