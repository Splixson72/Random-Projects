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
            int[] multiple = new int[10]; //THE INDEX OF THE ARRAY CORRELATES TO THE DIGIT //The duplicates will all cancel out anyway so its fine //but we still need them so its not
            int permutations = 1;
            int combinations = 1; //permutations dividd by combinations to find the rank-holding 1
            int ratio = 0; //This is the rank-holding 1
            //int noughtPermutations = 0; //these will cancel out too so its also fine
            int total = 0;
            //int rank = 0;
            //int[] orderedNumber = new int[12];
            //int[] originalNumber = new int[12];
            List<int> rankering = new List<int>();
            Program p = new Program();
            for (long i = 100000000000; i < 1000000000000; i++)
            {
                //Array.Clear(multiple, 0, multiple.Length); //RESETS THE COUNTER OF DIGITS                
                numberToFactorial = Convert.ToString(i);
                //noughtPermutations = 0;
                for (int j = 0; j < 12; j++)
                {
                    multiple[(numberToFactorial[j] - '0')] += 1; //COUNTS UP THE FREQUENCIES          
                }
                permutations = p.Factorial(numberToFactorial.Length); //n!
                combinations = permutations;
                for (int j = 0; j < 10; j++)
                {
                    if (multiple[j] > 1)
                    {
                        combinations /= p.Factorial(multiple[j]); //Divided by duplicates!
                    }
                }
                ratio = permutations / combinations;
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
                //}

                //this doesn't matter because it will cancel out anyway since no number we use will have a leading 0, so it will always be above them

                //DO INDEX MULTIPLIED BY FACTORIAL


            }
            //permutations -= noughtPermutations;
            //Console.WriteLine(numberToFactorial + " " + permutations); //NUMBER OF PERMUTATIONS WITH NO LEADING ZEROES CACLULATED

            //Finding the rank is even longer :/

            //lists are needed so i'll figure that out with Mr Stone tmw
            //List<string> DistinctDigits = new List<string>(numberToFactorial.Distinct);

            //HOW TO DO BASE FACTORIAL
            //continue dividing by the next number from 2 until you have a quotient of 0
            //1234
            //1234 / 2 = 617 r 0
            //617 / 3 = 205 r 2
            //205 / 4 = 51 r 1
            //51 / 5 = 10 r 1
            //10 / 6 = 1 r 4
            //1 / 7 = 0 r 1
            //1 * (7-1)! + 4 * (6-1)!........

            //AKA remainder * (multiplier - 1)! //working backwards
            Console.ReadLine();
        }
        public int Factorial(int length)
        {
            int combinations = 1;
            do
            {
                combinations *= length;
                length -= 1;
            } while (length > 1);
            return combinations;
        }
    }
}
