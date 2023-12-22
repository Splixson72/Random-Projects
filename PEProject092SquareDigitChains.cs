//Friday 22nd December 2023
//Problem 92 - Sqaure Digit Chains
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject092
{
    class Program
    {
        static void Main(string[] args)
        {
            //Answer - 8581146
            string chain = "";
            int startingNumber = 0;
            for (int i = 2; i < 10000000; i++)
            {
                chain = Convert.ToString(i);
                do
                {
                    double square = 0;           
                    for (int j = 0; j < chain.Length; j++)
                    {
                        square += Math.Pow(Convert.ToInt32(chain[j]) - '0',2);
                    }
                    chain = Convert.ToString(square);                  
                } while (chain != "1" && chain != "89");
                if (chain=="89")
                {
                    startingNumber += 1;
                }
            }
            Console.WriteLine(startingNumber);
            Console.ReadLine();
        }
    }
}
