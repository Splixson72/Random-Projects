//Tuesday 2nd January 2024
//Problem 67 - Maximum Path Sum II
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PEProject067_MaximumPathSum
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Answer - 7273
            StreamReader reader = new StreamReader("C:/Users/44784/OneDrive/Documents/Downloads/0067_triangle.txt");
            int[,] triangle = new int[100,100];
            string currentNumber = "";
            string currentLine = "";
            int counter = 0; //to figure out the starting row before proceeding along the diagonal
            int x = 0; // THE ROW - Only 100
            int y = 0; // THE COLUMN - Variable
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            do
            {
                currentLine = reader.ReadLine();
                x = counter;
                y = 0;
                for (int i = 0; i < currentLine.Length; i++)
                {
                    if (digits.Contains(currentLine[i]))
                    {
                        currentNumber += currentLine[i];
                    }
                    if (currentLine[i] == ' ' || i == currentLine.Length-1)
                    {
                        triangle[x, y] = Convert.ToInt32(currentNumber);
                        x -= 1; //goes along the diagonal
                        y += 1; //goes along the diagonal
                        currentNumber = "";
                    }
                }
                counter += 1;
            } while (!reader.EndOfStream);
            //Adds them all to a beatiful array
            //TO VERIFY THEY WERE CATALOGUED CORRECTLY
            ///int maximum = 100;
            ///int j = 0;
            ///do
            ///{
            ///    for (int i = 0; i < 100; i++)
            ///    {
               ///     Console.Write(triangle[i, j] + " ");
                  ///  maximum -= 1;
               /// }
               /// Console.WriteLine();
              ///  j += 1;
              ///  maximum -= 1;
           /// } while (j<100);

            //[0,0] will be the total overall
            //[x,y] is compared to [x+1,y] and [x,y+1]
            //X will go from 99 to 0 (m)
            //Y will go from 99 to 0 (n)
            ///Moving inwards to avoid needing to repeat since i cant do it recursively like Excel
            for (int m = 98; m >= 0; m--)
            {
                for (int n = 98; n >= 0; n--)
                {
                    if (triangle[m + 1, n] > triangle[m, n + 1]) //add the larger path
                    {
                        triangle[m, n] = triangle[m, n] + triangle[m + 1, n];
                    }
                    else {triangle[m, n] = triangle[m, n] + triangle[m, n+1];}
                }
            }
            Console.WriteLine(triangle[0, 0]);
            Console.ReadLine();
        }
    }
}
