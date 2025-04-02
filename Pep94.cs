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
            Int64 total = 0;
            int side1, side2, side3;
            int i = -1;
            do
            {
                i += 2;
                if (Math.Truncate(Math.Sqrt((3*i - 1)*(i+1)))== Math.Sqrt((3 * i - 1) * (i + 1)))
                {
                    total += i + i + i - 1;
                    Console.WriteLine(total);
                }
                if (Math.Truncate(Math.Sqrt((3 * i + 1) * (i - 1))) == Math.Sqrt((3 * i + 1) * (i - 1)))
                {
                    total += i + i + i - 1;
                    Console.WriteLine(total);
                }
                
                //side2 = i;
                //side3 = i + 1;
                //double semiperimeter = 0.5 * (side1 + side2 + side3);
                //double heronArea = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
                //if (Math.Truncate(heronArea) == heronArea)
                //{
                //    total += i + i + i + 1;
                //    Console.WriteLine(side1 + " " + side3 + " " + heronArea);

                //}
                //side3 = i - 1;
                //semiperimeter = 0.5 * (side1 + side2 + side3);
                //heronArea = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
                //if (Math.Truncate(heronArea) == heronArea)
                //{
                //    total += i + i + i - 1;
                //    Console.WriteLine(side1 + " " + side3 + " " + heronArea);
                //}
            } while (3*i +1 < 1000000001);

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
