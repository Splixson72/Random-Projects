//Wednesday 13th Decenber 2023
//Problem 32 - Pandigital Products
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
            int product = 0;
            string multiplicand = "";
            string multiplier = "";
            string identity = "";
            string combination = "";
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<string> addedNumbers = new List<string>();
            bool pan = true;
            for (int i = 0; i < 99999; i++)
            {
                for (int j = 0; j < 99999; j++)
                {
                    pan = true;
                  //  product = i * j;
                    multiplicand = Convert.ToString(i);
                    multiplier = Convert.ToString(j);
                    identity = Convert.ToString(i*j);
                    combination = multiplicand + multiplier + identity;
                   // Console.WriteLine(combination);
                    if (combination.Length == 9)
                    {
                        for (int k = 0; k < 9; k++)
                        {                
                            if (!combination.Contains(digits[k]))
                            {
                                pan = false;
                             //   Console.WriteLine("doesnt have " + digits[k]);
                            }
                        }
                        if (pan== true && !(addedNumbers.Contains(identity)))
                        {
                            Console.WriteLine(multiplier + " " + multiplicand + " " + identity + " has all! ");
                            product += Convert.ToInt32(identity);
                            addedNumbers.Add(identity);
                            Console.WriteLine(identity);// + Convert.ToInt32(identity));
                            Console.WriteLine("running total " + product);
                        }
                    }
                }
            }
            Console.WriteLine(product);
            Console.ReadLine();
        }      
    }
}