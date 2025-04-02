using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Problem89_RomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("U://0089_roman.txt");
            int count = 0;
            string num = "";
            int total = 0;
            do 
            {
                num = reader.ReadLine();
                count += num.Length;
                total += num.Length;
                if (num.Contains("IIII"))
                {
                    count -= 2;
                }
                if (num.Contains("CCCC"))
                {
                    count -= 2;
                }
                if (num.Contains("XXXX"))
                {
                    count -= 2;
                }
                if (num.Contains("VIIII"))
                {
                    count += 2;
                    count -= 3;
                }
                if (num.Contains("DCCCC"))
                {
                    count += 2;
                    count -= 3;
                }
                if (num.Contains("LXXXX"))
                {
                    count += 2;
                    count -= 3;
                }              
                Console.WriteLine(num +" " + num.Length + " " + count);
            }
            while (!reader.EndOfStream);
            Console.WriteLine($"{total} - {count} = {total-count}");
            Console.ReadLine();
        }
    }
}
