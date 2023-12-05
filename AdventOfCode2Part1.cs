using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AOC2
{
    class Program
    {
        static void Main(string[] args)
        {
            //12 red cubes, 13 green cubes, and 14 blue cubes
            string cubes = "0";
         //   string red = "12";
         //   string green = "13";
        //   string blue = "14";
            int counter = 0;
            int total = 0;
            //string littleString;
            bool valid = true;
            //bool num = false;
            char[] digit = { '0', '1', '2','3', '4', '5', '6', '7', '8', '9' };
            StreamReader reader = new StreamReader("U:/AOC2.txt");          
            do
            {
                string line = reader.ReadLine();
                counter += 1;
                valid = true;
               // int firstIndex = line.IndexOf(':') + 1;
               // int lastIndex = ;
                for (int i = 0; i < line.Length; i++)
                {
                    //valid = true;
                   // Console.WriteLine("current i " + line[i]);
                    //counter += 1;
                    //if (line[i]==':')
                    //{
                    //    num = true;
                    //}
                    //if (num==true)
                    //{
                        if (digit.Contains(line[i]))
                        {
                            cubes += line[i];
                        //Console.WriteLine(cubes);
                        }
                    //}
                   // if (cubes != "0")
                    //{
                        if (line[i] == 'r' && line[i - 1] == ' ')
                        {
                        //Console.WriteLine(Convert.ToInt32(cubes));
                    if (Convert.ToInt32(cubes) > 12)
                    {
                        valid = false;
                    }
                   // Console.ForegroundColor = ConsoleColor.Red;
                   // Console.WriteLine(counter + " " + cubes);
                   // Console.ForegroundColor = ConsoleColor.White;
                }
                        if (line[i] == 'g' && line[i - 1] == ' ')
                        {
                            //Console.WriteLine(cubes);
                            if (Convert.ToInt32(cubes) > 13)
                            {
                            valid = false;                            
                            }
                       // Console.ForegroundColor = ConsoleColor.Green;
                        //Console.WriteLine(counter + " " + cubes);
                       // Console.ForegroundColor = ConsoleColor.White;
                          }
                        if (line[i] == 'b' && line[i - 1] == ' ')
                        {
                            if (Convert.ToInt32(cubes) > 14)
                            {
                                valid = false;
                        }
                      //  Console.ForegroundColor = ConsoleColor.Blue;
                      //  Console.WriteLine(counter + " " + cubes);
                     //   Console.ForegroundColor = ConsoleColor.White;
                    }
                   // }
                   
                    if (line[i] == ',' || line[i] == ';' || line[i] == ':')
                    {
                        cubes = "0";
                    }
                   
                    }
                if (valid == true)
                {
                    //Console.WriteLine(counter + " " + valid);
                    total += counter;
                    //littleString = line.Substring((firstIndex, line.Length-lastIndex));
                }
                //line.Remove(line.IndexOf(':'));
               
                //5355 too high
                //102 too low
                //2716 is right!
            } while (!reader.EndOfStream);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
