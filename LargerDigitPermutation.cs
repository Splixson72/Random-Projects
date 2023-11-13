using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LargerDigitPermutation
{
    class Program
    {
       static void Main(string[] args)
        {
            string numberToFactorial = "";
            int[] multiple = new int[10]; //THE INDEX OF THE ARRAY CORRELATES TO THE DIGIT
            int permutations = 1;
            //int noughtPermutations = 0;
            Program p = new Program();
            for (long i = 100000000000; i < 1000000000000; i++)
            {
                Array.Clear(multiple, 0, multiple.Length); //RESETS THE COUNTER OF DIGITS                
                numberToFactorial = Convert.ToString(i);
                //noughtPermutations = 0;
                //for (int j = 0; j < 12; j++)
                //{
                //    multiple[(numberToFactorial[j] - '0')] += 1; //COUNTS UP THE FREQUENCIES          
                //}             
                permutations = p.Factorial(numberToFactorial.Length); //n!
               
                for (int j = 0; j < 10; j++)
                {
                    if (multiple[j] > 1)
                    {
                        permutations /= p.Factorial(multiple[j]); //Divided by duplicates!
                    }                  
                }
                //if (numberToFactorial.Contains('0'))
                //{
                    //noughtPermutations = p.Factorial(numberToFactorial.Length - 1); //n-1!;
                    //for (int j = 0; j < 10; j++)
                    //{
                        //multiple[0] -= 1; //subtracting number of leading zeroes
                        //if (multiple[j] > 1)
                        //{
                            //noughtPermutations /= p.Factorial(multiple[j]); //Divided by duplicates!
                        //}
                    //}
                //this doesn't matter because it will cancel out anyway since no number we use will have a leading 0, so it will always be above them
                }               
                permutations -= noughtPermutations;
                Console.WriteLine(numberToFactorial + " " + permutations); //NUMBER OF PERMUTATIONS WITH NO LEADING ZEROES CACLULATED

                //Finding the rank is even longer :/
                //lists are needed so i'll figure that out with Mr Stone tmw
                //List<string> DistinctDigits = new List<string>(numberToFactorial.Distinct)
                    ;
            } 

            

            Console.ReadLine();
        }
      public int Factorial(int length)
        {
            int combinations = 1;
            do
            {
                combinations *= length;
                length -= 1;
            } while (length>1);
            return combinations;
        }
    }
}
