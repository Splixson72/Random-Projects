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
            //Console.WriteLine("o");
            StreamReader reader = new StreamReader("");
            string lineToRead = "";
            ///Create Triangle Numbers
            List<double> triangleNumbers = new List<double>();
            double currentTri = 0;
            for (double i = 1; i < 100; i++)
            {
                //Console.WriteLine(i);
                currentTri = i * (i + 1);
                currentTri /= 2;
                //Console.WriteLine(currentTri);
                triangleNumbers.Add(currentTri);
            }
            //Console.WriteLine(triangleNumbers.Count);

            ///Figure out the value of the letter
            ///find the appropriate triangle number index-wise
            ///sum it up
            ///see if it is a triangle number
            ///if it is, add one to the counter
            do
            {
                lineToRead = reader.ReadLine();
                for (int i = 0; i < lineToRead.Length; i++)
                {
                    
                }
            } while (!reader.EndOfStream);
            Console.ReadLine();
        }
    }
}
