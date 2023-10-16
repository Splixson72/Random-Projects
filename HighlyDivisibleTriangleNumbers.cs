//Thursday 16th October 2023
//Highly Divisible Triangle Numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HighlyDivisibleTriangleNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentTri = 0;
            int triAdd = 1;
            int numFactors = 1;//1 is always a factor
            int highFactor = 0;
            for (int i = 0; i < 2000000; i++)
            {
                currentTri += triAdd;
                triAdd++;
                for (int j = 2; j <= currentTri; j++) //going through a billion numbers
                {
                    if (currentTri % j == 0) //this checks if it is a factor
                    {                   
                        numFactors += 1;
                        if (j == currentTri)
                        {
                            Console.WriteLine(numFactors + " " + currentTri);
                            if (numFactors > highFactor)
                            {
                                Console.WriteLine(numFactors + " " + currentTri);
                                highFactor = numFactors;
                                numFactors = 1;
                                j = 2;
                            }
                        }
                    }
                  
                }
                numFactors = 0;
                if (highFactor >= 500)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
