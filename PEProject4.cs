//Tuesday 26th September 2023
//Project Euler 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PalidromeProduct;
            int highScore=0;
            string stringPalindrome;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    PalidromeProduct = i * j;
                    stringPalindrome = PalidromeProduct.ToString();
                    if (highScore < PalidromeProduct)
                    {
                        if (stringPalindrome[stringPalindrome.Length - 1] == stringPalindrome[0])
                        {
                            if (stringPalindrome[stringPalindrome.Length - 2] == stringPalindrome[1])
                            {
                                if (stringPalindrome[stringPalindrome.Length - 3] == stringPalindrome[2])
                                {
                                    highScore = PalidromeProduct;
                                    Console.WriteLine(stringPalindrome);
                                    Console.WriteLine(i + " and " + j);
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
