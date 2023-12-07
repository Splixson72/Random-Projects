using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AOC3Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("U:/AOC3.txt");
            //The engine schematic(your puzzle input) consists of a visual representation of the engine.
            //There are lots of numbers and symbols you don't really understand,
            //but apparently any number adjacent to a symbol, even diagonally,
            //is a "part number" and should be included in your sum.
            //(Periods (.) do not count as a symbol.)
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string lineBeingRead; string lineAbove;string lineBelow;
            string currentNumber = "";
            do
            {
                lineBeingRead = reader.ReadLine();
                lineBelow = reader.ReadLine();
                for (int i = 0; i < lineBeingRead.Length; i++)
                {
                    if (digits.Contains(lineBeingRead[i]))
                    {
                        currentNumber += lineBeingRead[i];
                    }
                    if (!digits.Contains(lineBeingRead[i]) && !(currentNumber==""))
                    {
                        
                        //Console.WriteLine(currentNumber);
                        currentNumber = ""; //ALL THE NUMBERS ARE READ ACCORDINGLY
                    }
                }
                //Console.WriteLine(lineBeingRead);
                lineAbove = lineBeingRead;
            } while (!reader.EndOfStream);
            Console.ReadLine();

        }
    }
}
