//Wednesday 13th Decenber 2023
//Problem 36 - Double-base Palidromes
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
            int total = 0;
            string yarn = ""; 
            for (int i = 0; i < 1000000; i++)
            {
                yarn = Convert.ToString(i);
                Console.WriteLine(i + " " + yarn + " " +yarn.Reverse());
                if (Convert.ToString(i) == Convert.ToString(Convert.ToString(i).Reverse()))
                {
                    Console.WriteLine(i);
                    if (true)
                    {
                        if (Convert.ToString(i,2) == Convert.ToString(Convert.ToString(i, 2).Reverse()))
                        {
                            Console.WriteLine(i + " " + Convert.ToString(i, 2));
                            total += i;
                        }
                    }
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
