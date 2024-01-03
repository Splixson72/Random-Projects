//Wednesday 3rd January 2024
//Problem 44 - Pentagon Numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject041PandigitalPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Answer - 5482660
            List<double> PentagonList = new List<double>();
            double currentPent = 0;
            for (int i = 1; i < 10000; i++)
            {
                currentPent = ((3 * i - 1) * i) / 2;
                PentagonList.Add(currentPent);
            }
            for (int i = 1; i < 9999; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    double sum = PentagonList[i] + PentagonList[j];
                    double difference = PentagonList[i] - PentagonList[j];
                    //Console.WriteLine(PentagonList[i] + " " + PentagonList[j] + ": " + sum + " " + difference);
                    if (PentagonList.Contains(sum))
                    {
                        if (PentagonList.Contains(difference))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(PentagonList[i] + " " + PentagonList[j]);
                            Console.WriteLine(difference);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                       
                    }
                }
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
