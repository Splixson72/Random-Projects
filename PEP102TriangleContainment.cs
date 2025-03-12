using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TriangleContainment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("U:\\0102_triangles.txt");
            int count = 0;
            do 
            {
                string[] coordinates = reader.ReadLine().Split(',');
                decimal p0x = Convert.ToDecimal(coordinates[0]);
                decimal p0y = Convert.ToDecimal(coordinates[1]);
                decimal p1x = Convert.ToDecimal(coordinates[2]);
                decimal p1y = Convert.ToDecimal(coordinates[3]);
                decimal p2x = Convert.ToDecimal(coordinates[4]);
                decimal p2y = Convert.ToDecimal(coordinates[5]);
                decimal area = ((-p1y * p2x) + (p0y * (-p1x + p2x)) + (p0x * (p1y - p2y)) + (p1x * p2y));
                decimal s = 1 / (area) * (p0y * p2x - p0x * p2y + (p2y - p0y) * 0 + (p0x - p2x) * 0);
                decimal t = 1 / (area) * (p0x * p1y - p0y * p1x + (p0y - p1y) * 0 + (p1x - p0x) * 0);
                if (t > 0 && s > 0 && 1 - s - t > 0) { count++; }
            }
            while (!reader.EndOfStream);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
