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
            int numFactors = 0;
            for (int i = 0; i < 2000000; i++)
            {
                currentTri += triAdd;
                triAdd++;
                for (int j = 2; j < currentTri; j++) //going through a billion numbers
                {
                  
                        if (currentTri % j == 0) //this checks if it is a factor
                        {
                            currentTri = currentTri / j; //by continually making the number smaller, we eliminate the factors so to not repeat them                                                               
                            j = 2; //we start at 2 to avoid continually dividing by 1 (which is not prime)
                        }
                    }                  
                    
                }
            }
        }
    }
}
