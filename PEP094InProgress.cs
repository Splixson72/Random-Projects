//Monday 8th January 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PEP94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Answer - 887958026
            //Answer? - 86482280020346
            //Answer? - 86482280020346
            //172956392587324
            
            Int64 total = 0;
            int side1, side2, side3;
            int i = 0;
            do
            {
                i += 1;
                side1 = i;
                side2 = i;
                side3 = i + 1;
                double perimeter = (side1 + side2 + side3) * (-side1 + side2 + side3) * (side1 - side2 + side3) * (side1 + side2 - side3);
                double area = Math.Sqrt(perimeter) / 4;
                if (Math.Truncate(area) == area)
                {
                    total += i + i + i + 1; 
                    Console.WriteLine(side1 + " " + side3 + " " + area);
                    Console.ReadLine();

                }
                side3 = i - 1;
                 perimeter = (side1 + side2 + side3) * (-side1 + side2 + side3) * (side1 - side2 + side3) * (side1 + side2 - side3);
                 area = Math.Sqrt(perimeter) / 4;
                if (Math.Truncate(area) == area)
                {
                    total += i + i + i + 1;
                    Console.WriteLine(side1 + " "+ side3 + " "+ area);
                    Console.ReadLine();
                }
            } while (side1 + side2 + side3 < 1000000001);
         
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
