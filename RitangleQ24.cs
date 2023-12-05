using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BasicallyDual
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            string num2;
            int total =0;
            for (int i = 10; i < 100; i++)
            {
                for (int j = 10; j < 100; j++)
                {
                    num1 = Convert.ToString(i);
                    num2 = Convert.ToString(j);   
                    if ((Convert.ToInt32(num1[0]) - '0') * j + (Convert.ToInt32(num1[1]) - '0') == (Convert.ToInt32(num2[0]) - '0') *i + (Convert.ToInt32(num2[1] - '0')) && i!=j)
                    {
                       // Console.WriteLine(i + " " + ((Convert.ToInt32(num1[0]) - '0') * j + (Convert.ToInt32(num1[1]) - '0'))); 
                       // Console.WriteLine(j + " " + ((Convert.ToInt32(num2[0]) - '0') * i + (Convert.ToInt32(num2[1] - '0'))));
                        if (i+j>total)
                        {
                            total = i + j;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(i + " " + j + " " + (i + j));
                            Console.ForegroundColor = ConsoleColor.White;
                        }                       
                    }
                }
            }
            Console.ReadLine();
        }
    }
}