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
                p.Type("Number: "+ numberToFactorial);
                for (int j = 0; j < 12; j++)
                {
                    multiple[(numberToFactorial[j] - '0')] += 1; //COUNTS UP THE FREQUENCIES          
                }
                permutations = p.Factorial(numberToFactorial.Length); //n!
             //  p.Type("Permutations " +permutations);
                combinations = permutations;
                for (int g = 0; g < 12; g++)
                {
                    //Console.WriteLine("Digit; " + numberToFactorial[g]);
                    copyTheNumber.Add(Convert.ToInt32(numberToFactorial[g] - '0'));
                    //Console.WriteLine(copyTheNumber[g]);
                }
                //Console.WriteLine(copyTheNumber.Count);
                for (int j = 0; j < 10; j++)
                {
                    //  Console.WriteLine(multiple[j] + " " + j);
                    if (multiple[j] > 1)
                    {
                        combinations /= p.Factorial(multiple[j]); //Divided by duplicates!
                    }
                }
            //   p.Type("Combinations "+ combinations);
                ratio = permutations / combinations;
             //   p.Type("Ratio " + ratio);
                //DO INDEX MULTIPLIED BY FACTORIAL
                for (int y = 0; y < 10; y++) //Creates a list with the numbers in Order
                {
                    do
                    {
                        if (copyTheNumber.Contains(y))
                        {
                            //Console.WriteLine("Y is: " +y);
                            orderTheNumber.Add(y);
                            copyTheNumber.Remove(y);
                        }
                    } while (copyTheNumber.Contains(y));            
                }
                //Console.WriteLine(copyTheNumber.Count + " " + orderTheNumber.Count);
                // for (int g = 0; g < orderTheNumber.Count; g++)
                // {
                //    Console.WriteLine("List g " + orderTheNumber[g]);
                //}
              
                for (int q = 12; q > 1; q--)
                {
                    //Console.WriteLine(p.Factorial(q - 1));
                   // Console.WriteLine("index?: " + numberToFactorial[3 - q]);          
                  //  Console.WriteLine(orderTheNumber.IndexOf(numberToFactorial[3 - q] - '0'));
                    //if (!(orderTheNumber.IndexOf(numberToFactorial[3 - q]) == -1))
                    //{
                        rank += p.Factorial(q - 1) * orderTheNumber.IndexOf(numberToFactorial[12 - q] - '0');
                    orderTheNumber.Remove(numberToFactorial[12 - q] - '0');
                //    Console.WriteLine("orderleangth "+ orderTheNumber.Count);
                    //}            
                   // Console.WriteLine(rank);
                }
                rank += ratio; //gets to the correct rank
              //  Console.WriteLine("Initial Rank: " + rank);
                if (!(rank % ratio == 0)) //gets to the real correct rank
                {
                    do
                    {
                        rank += 1;
                    } while (!(rank % ratio == 0));
                }
               // Console.WriteLine("rank with duplicates " + rank);
                rank = ((p.Factorial(12) - rank) / ratio);
               // biggerNumbers = 
                //Console.WriteLine("number of numbers bigger: "+ rank);
                total += rank;
                //Console.WriteLine("Current Total: " + total);
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
