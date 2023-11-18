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
            long total = 0;
            int rank = 0;
            //int biggerNumbers = 0;
            List<int> orderTheNumber = new List<int>();
            List<int> copyTheNumber = new List<int>();
            //List<int> rankering = new List<int>();
            Program p = new Program();
            for (long i = 100000000000; i < 1000000000000; i++)
            {
                //permutations = 1;
                //combinations = 1;
                orderTheNumber.Clear();
                copyTheNumber.Clear();
                rank = 0;
                Array.Clear(multiple, 0, multiple.Length); //RESETS THE COUNTER OF DIGITS                
                numberToFactorial = Convert.ToString(i);
                if (Convert.ToInt64(numberToFactorial) % 1000000 == 0)
                {
                    p.Type("Number: " + numberToFactorial);
                    Console.WriteLine(rank);
                }
                //p.Type("Number: "+ numberToFactorial);
                for (int j = 0; j < 12; j++)
                {
                    multiple[(numberToFactorial[j] - '0')] += 1; //COUNTS UP THE FREQUENCIES
                    copyTheNumber.Add(Convert.ToInt32(numberToFactorial[j] - '0'));
                }
                permutations = p.Factorial(numberToFactorial.Length); //n!
                combinations = permutations;               
                for (int j = 0; j < 10; j++)
                {
                    if (multiple[j] > 1)
                    {
                        combinations /= p.Factorial(multiple[j]); //Divided by duplicates!
                    }
                    do  //Creates a list with the numbers in Order
                    {
                        if (copyTheNumber.Contains(j))
                        {
                            orderTheNumber.Add(j);
                            copyTheNumber.Remove(j);
                        }
                    } while (copyTheNumber.Contains(j));
                }
                ratio = permutations / combinations;
                for (int q = 12; q > 1; q--)
                {
                        rank += p.Factorial(q - 1) * orderTheNumber.IndexOf(numberToFactorial[12 - q] - '0');
                    orderTheNumber.Remove(numberToFactorial[12 - q] - '0');
                }
                rank += ratio; //gets to the correct rank
                if (!(rank % ratio == 0)) //gets to the real correct rank
                {
                    do
                    {
                        rank += 1;
                    } while (!(rank % ratio == 0));
                }
                rank = ((p.Factorial(12) - rank) / ratio);
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
