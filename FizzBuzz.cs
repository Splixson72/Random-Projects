//Tuesday 26th September 2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            for (int i = 1; i < 101; i++) //i++ is i += 1
            {
                if (i % 5 == 0 & i % 3 == 0) //& is AND
                {
                    Console.WriteLine("FizzBuzz");       
                    }
                else if (i % 5 == 0) // == is how you do equals
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0) //% is Modulo
                {
                    Console.WriteLine("Fizz");
                }
                else
                    Console.WriteLine(i);    
                // No EndIf, the semicolon symbolises it
            }
            Console.ReadLine();
        }
    }
}
