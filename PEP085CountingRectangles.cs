using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEP85CountingRectangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int closest = 0;
             int area = 0;
            for (int i = 0; i <= 1415; i++) 
            {
                int numRect = 0;
                for (int j = 0; j <= 1415; j++)
                {
                    numRect = (i * (i + 1) * j * (j + 1) / 4);

                    if (Math.Abs(2000000 - numRect) < Math.Abs(2000000 - closest))
                    {
                        closest = numRect;
                        area = i * j;
                    }
                }
            }
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}
