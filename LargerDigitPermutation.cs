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
            int[] multiple = new int[10]; //THE INDEX OF THE ARRAY CORRELATES TO THE DIGIT //The duplicates will all cancel out anyway so its fine //but we still need them so its not             
            long total = 0;         
            List<int> orderTheNumber = new List<int>();
            Program p = new Program();
            int numberOfDigits = 12;
            int permutations = p.Factorial(numberOfDigits); //n!
            for (long i = Convert.ToInt64(Math.Pow(10,numberOfDigits-1)); i < Convert.ToInt64(Math.Pow(10, numberOfDigits)); i++)
            {
                Console.WriteLine(i);
                orderTheNumber.Clear(); int rank = 0; Array.Clear(multiple, 0, multiple.Length); //RESETS THE COUNTER OF DIGITS                
                string numberToFactorial = Convert.ToString(i);  
                for (int j = 0; j < numberOfDigits; j++)
                {
                    multiple[numberToFactorial[j] - '0'] += 1; //COUNTS UP THE FREQUENCIES
                    orderTheNumber.Add(numberToFactorial[j] - '0');
                }             
                int combinations = permutations; //permutations divided by combinations to find the rank-holding 1
                for (int j = 0; j < 10; j++)
                {
                    if (multiple[j] > 1)
                    {
                        combinations /= p.Factorial(multiple[j]); //Divided by duplicates!
                    }
                }
                orderTheNumber.Sort();
                int ratio = permutations / combinations; //this is the rank holding 1
                for (int q = numberOfDigits; q > 1; q--)
                {
                    rank += p.Factorial(q - 1) * orderTheNumber.IndexOf(numberToFactorial[numberOfDigits - q] - '0');
                    orderTheNumber.Remove(numberToFactorial[numberOfDigits - q] - '0');
                }
                rank += ratio; //gets to the correct rank
                if (!(rank % ratio == 0)) //gets to the real correct rank
                {
                    do
                    {
                        rank += 1;
                    } while (!(rank % ratio == 0));
                }
                rank = (permutations - rank) / ratio;
                total += rank;
            }
            p.Type("Total " + total);
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
        public string Type(string yarn)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(yarn);
            Console.ForegroundColor = ConsoleColor.White;
            return "";
        }
    }
}
