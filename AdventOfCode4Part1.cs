using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AOC4Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> WinningNumbers = new List<string>();
            List<string> cardNumbers = new List<string>();
            string currentNumber="";
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StreamReader reader = new StreamReader("U:/AOC4.txt");
            string line;
            bool bar = false;
            int points = 0;
            int total = 0;
            int p = 1;
            do
            {
                WinningNumbers.Clear();
                cardNumbers.Clear();
                Console.WriteLine("line " + p);
                p += 1;
                line = reader.ReadLine();
                points = 0;
                bar = false;
                for (int i = 0; i < line.Length; i++)
                {
                    //  points = 0;
                    //Console.Write(line[i]);
                    if (line[i] == '|')
                    {
                        bar = true;
                    }
                    if (digits.Contains(line[i]))
                    {
                        currentNumber += line[i];
                    }
                    if (bar == false)
                    {
                        if (line[i] == ' ' && currentNumber != "")
                        {
                            WinningNumbers.Add(currentNumber);
                            //Console.WriteLine(currentNumber);
                            currentNumber = "";
                        }
                    }
                    if (bar==true)
                    {
                        if (line[i] == ' ' && currentNumber != "")
                        {
                            cardNumbers.Add(currentNumber);
                          //  Console.WriteLine(currentNumber);
                            currentNumber = "";
                        }                      
                    }
                 //   if (i==line.Length-1)
                   // {
                     //   for (int m = 0; m < cardNumbers.Count; m++)
                       // {
                         //   for (int n = 0; n < WinningNumbers.Count; n++)
                           // {
                               // if (cardNumbers[m] == WinningNumbers[n])
                               // {
                                //   Console.WriteLine(cardNumbers[m] + " " + WinningNumbers[n]);
                                //  if (points == 0)
                                   // {
                                  //      points = 1;
                                   // }
                                   // if (points!=0)
                                  //  {
                                //        points *= 2;
                              //      }
                            //    }
                          //  }
                        //}
                    //}
                    for (int m = 0; m < cardNumbers.Count; m++)
                    {
                        for (int n = 0; n < WinningNumbers.Count; n++)
                        {
                            if (cardNumbers[m] == WinningNumbers[n])
                            {
                               // Console.WriteLine(cardNumbers[m] + " " + WinningNumbers[n]);
                                if (points == 0)
                                {
                                    points = 1;
                                }
                                if (points != 0)
                                {
                                    points *= 2;
                                }
                            }
                        }
                    }
                    total += points;
                }

            } while (!reader.EndOfStream);
            Console.WriteLine(total);
                Console.ReadLine();
        }
    }
}
