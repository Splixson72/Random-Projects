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
            int combinations = 1; //permutations divided by combinations to find the rank-holding 1
            int ratio = 0; //This is the rank-holding 1         
            int total = 0;
            int rank = 0;
            List<int> orderTheNumber = new List<int>();
            List<int> copyTheNumber = new List<int>();
            //List<int> rankering = new List<int>();
            Program p = new Program();
            for (long i = 100; i < 1000; i++)
            {
                permutations = 1;
                combinations = 1;
                rank = 0;
                Array.Clear(multiple, 0, multiple.Length); //RESETS THE COUNTER OF DIGITS                
                numberToFactorial = Convert.ToString(i);
                Console.WriteLine(numberToFactorial);
                for (int j = 0; j < 3; j++)
                {
                    multiple[(numberToFactorial[j] - '0')] += 1; //COUNTS UP THE FREQUENCIES          
                }              
                permutations = p.Factorial(numberToFactorial.Length); //n!
                Console.WriteLine(permutations);
                combinations = permutations;
                for (int g = 0; g < 3; g++)
                {
                    copyTheNumber.Add(Convert.ToInt32(numberToFactorial[g]));
                }
                for (int j = 0; j < 10; j++)
                {
                  //  Console.WriteLine(multiple[j] + " " + j);
                    if (multiple[j] > 1)
                    {
                        combinations /= p.Factorial(multiple[j]); //Divided by duplicates!
                    }
                }
                Console.WriteLine(combinations);
                ratio = permutations / combinations;
                //DO INDEX MULTIPLIED BY FACTORIAL
                for (int y = 0; y < 10; y++) //Creates a list with the numbers in Order
                {
                    do
                    {
                        if (copyTheNumber.Contains(y))
                        {
                            //Console.WriteLine(y);
                            orderTheNumber.Add(y);
                            copyTheNumber.Remove(y);
                        }
                    } while (copyTheNumber.Contains(y));               
                }
                //Console.WriteLine(copyTheNumber);
                for (int q = 3; q > 0; q--)
                {
                    rank += (p.Factorial(q-1) * orderTheNumber.IndexOf(numberToFactorial[3-q]));
                }
                rank += ratio; //gets to the correct rank
                
                if (!(rank % ratio == 0)) //gets to the real correct rank
                {
                    do
                    {
                        rank += 1;
                    } while (!(rank % ratio == 0));
                }
                Console.WriteLine(rank);
                total += ((p.Factorial(3) - rank) / ratio);
            }
            Console.WriteLine(total);
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