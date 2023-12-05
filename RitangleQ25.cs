using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summations
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            for (int i = 2; i < 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(p.Summation(i,2)/ p.Summation(i, 1));
                Console.WriteLine(p.Summation(i, 4) / p.Summation(i, 1));
                Console.WriteLine(p.Summation(i, 4) / p.Summation(i, 2));
                //Console.WriteLine("new line");
            }
           Console.ReadLine();
        }
        double Summation(int higher,int power)
        {
            double total = 0;
            for (int i = 1; i < higher+1; i++)
            {
                total += Math.Pow(i, power);
            }
            return total;
        }
    }
}
