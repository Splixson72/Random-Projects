//Thursday 21st December 2023
//Problem 42 - Coded Triangle Numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PEProject9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Answer - 162
            StreamReader reader = new StreamReader("C:/Users/44784/OneDrive/Documents/words.txt");
            ///Create Triangle Numbers
            List<double> triangleNumbers = new List<double>();
            double currentSum = 0;
            int totalNumber = 0;
            for (double i = 1; i < 1000; i++)
            {
                double currentTri = i * (i + 1);
                currentTri /= 2;
                triangleNumbers.Add(currentTri);
            }
            //Console.WriteLine(triangleNumbers.Count);

            ///Figure out the value of the letter
            ///find the appropriate triangle number index-wise
            ///sum it up
            ///see if it is a triangle number
            ///if it is, add one to the counter        
                string lineToRead = reader.ReadLine();
                for (int i = 0; i < lineToRead.Length; i++) ///Luckily its just one line
                {
                    if (Convert.ToInt16(lineToRead[i]) > 64)
                    {
                        currentSum += Convert.ToInt16(lineToRead[i] - 64);
                    }
                    if (lineToRead[i] == ',')
                    {
                        if (triangleNumbers.Contains(currentSum))
                        {
                            totalNumber += 1;
                        }
                        currentSum = 0;
                    }
                }
            Console.WriteLine(totalNumber);
            Console.ReadLine();
        }
    }
}
