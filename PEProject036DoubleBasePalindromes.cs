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
            string nray = "";
            string biyarn = "";
            string binray = "";
            for (int i = 0; i < 1000000; i++)
            {
                yarn = Convert.ToString(i);
                nray = "";
                for (int o = 0; o < yarn.Length; o++)
                {
                    nray = yarn[o] + nray;
                }
               // Console.WriteLine(Convert.ToString(i, 2));
               biyarn = Convert.ToString(i, 2);
                binray = "";
                for (int o = 0; o < biyarn.Length; o++)
                {
                    binray = biyarn[o] + binray;
                }
               // Console.WriteLine(yarn + " " + nray + " " + biyarn + " " + binray);
               // Console.ReadLine();
                if (yarn==nray && biyarn==binray)
                {
                   // Console.WriteLine(yarn + " " + nray + " " + biyarn + " " + binray);
                    total += i;
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
