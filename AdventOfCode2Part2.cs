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
            string cubes = "0";
               int red = 0;
              int green = 0;
              int blue = 0;
            int counter = 0;
            int total = 0;
            //bool valid = true;
            char[] digit = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StreamReader reader = new StreamReader("C:/Users/44784/OneDrive/Documents/AOC2.txt");
            do
            {
                red = 0;
                green = 0;
                blue = 0;
                string line = reader.ReadLine();
                counter += 1;
                for (int i = 0; i < line.Length; i++)
                {
                    if (digit.Contains(line[i]))
                    {
                        cubes += line[i];
                    }

                    if (line[i] == 'r' && line[i - 1] == ' ')
                    {
                        if (Convert.ToInt32(cubes) > red)
                        {
                            red= Convert.ToInt32(cubes);
                        }
                       
                    }
                    if (line[i] == 'g' && line[i - 1] == ' ')
                    {
                        if (Convert.ToInt32(cubes) > green)
                        {
                            green = Convert.ToInt32(cubes);
                        }                     
                    }
                    if (line[i] == 'b' && line[i - 1] == ' ')
                    {
                        if (Convert.ToInt32(cubes) > blue)
                        {
                            blue = Convert.ToInt32(cubes);
                        }
                    }
                    if (line[i] == ',' || line[i] == ';' || line[i] == ':')
                    {
                        cubes = "0";
                    }
                } 
                    total += red*green*blue;
            } while (!reader.EndOfStream);
            Console.WriteLine(total);
            //685122 too high
            Console.ReadLine();
        }
    }
}