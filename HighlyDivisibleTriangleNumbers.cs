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
            int numFactors = 1; //1 is always a factor
            int highFactor = 0;
            int bestNumber = 0;
            do
            {
                currentTri += triAdd;
                triAdd++;
                for (int j = 2; j <= currentTri; j++) //finding all the factors
                {
                    if (currentTri % j == 0) //this checks if it is a factor
                    {
                        numFactors += 1;
                        if (j == currentTri) //if we've reached the end
                        {
                            //Console.WriteLine(numFactors + " " + currentTri);
                            //numFactors += 1;
                            if (numFactors > highFactor)
                            {
                                Console.WriteLine(numFactors + " " + currentTri);
                                highFactor = numFactors;                          
                                bestNumber = currentTri;
                               j = 2;
                            }
                            numFactors = 1;
                        }
                    }
                }
            } while (highFactor < 500);
                    Console.WriteLine(bestNumber);
                    Console.ReadLine();
                }
            }
        } 