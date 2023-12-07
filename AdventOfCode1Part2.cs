using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AOC1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("C:/Users/44784/OneDrive/Documents/AOC1.txt");
            int total = 0;
            string num1 = "";
           //Console.WriteLine(num1);
            string num2 = "";
            string line;
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string[] dights = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string currentline = "";
           // bool found = false;
            do
            {
                num1 = "";
                num2 = "";
                int count = 0;
                currentline = "";
                line =reader.ReadLine();
                do
                {
                    currentline += line[count];
                    //Console.WriteLine(currentline);
                    //num1 = "";
                    //    num2 = "";
                    if (numbers.Contains(line[count]))
                    {
                        num1 = Convert.ToString(line[count]);
                    }
                    for (int i = 0; i <= 8; i++)
                    {
                        if (currentline.Contains(dights[i]))
                        {
                            //found = true;
                            num1 = Convert.ToString(i + 1);
                            //Console.WriteLine("num1 " + Convert.ToString(i + 1));
                            //Console.WriteLine(num1);
                        }
                    }
                    count += 1;
                } while (num1 == "");// || found == true);
                count = line.Length - 1;
                currentline = "";
                //Console.ForegroundColor = ConsoleColor.Yellow;
                do
                {
                    currentline = line[count] + currentline;
                    //Console.WriteLine(currentline);
                    if (numbers.Contains(line[count]))
                    {
                        num2 = Convert.ToString(line[count]);
                    }
                    for (int i = 0; i <= 8; i++)
                    {
                        if (currentline.Contains(dights[i]))
                        {
                            //found = true;
                            num2 = Convert.ToString(i + 1);                         
                            //Console.WriteLine("num2 " + Convert.ToString(i + 1));
                            //Console.WriteLine(num2);
                        }
                    }
                    count -= 1;
                } while (num2 == "");
                num1 = num1 + num2;
                //Console.WriteLine("total " + num1);
                total += Convert.ToInt32(num1);
                //53881 too low
            } while (!reader.EndOfStream);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
