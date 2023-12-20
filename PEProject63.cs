//Wednesday 20th December 2023
//Problem 63 - Powerful Digit Counts
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Answer: 49
            int counter = 0;
            int nDigit = 0;           
            for (int k = 0; k < 23; k++)
            {
                counter += 1;
                for (int i = 1; i < 10; i++)
                {
                    string exponent = "";
                    string powerful = Convert.ToString(Math.Pow(i, counter));
                    if (powerful.Contains("E")) //the number of digits is the x10 + 1
                    {      
                        exponent = powerful.Substring(powerful.Length - 2); //power
                        int PowerNow = Convert.ToInt32(exponent) + 1; //number of digits
                        if (PowerNow==counter) //number of digits = power
                        {                     
                            nDigit += 1;
                        }
                    }
                    else //if it a normal number
                    {
                        if (powerful.Length == counter) //just check the length!
                        {
                          
                            nDigit += 1;
                        }
                    }  
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Total " + nDigit);
            Console.ReadLine();
        }
    }
    }