using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonnacciTriangles
{
   internal class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.Fibonnacci(2);
            double side1;
            double side2;
            double side3;
            double perimeter;
            double area;
            for (int i = 0; i < 1000; i++)
            {
               side1= Fibonacci(i + 2);
                side2 = Math.Sqrt(Fibonacci(2*i + 1));
                side3= Fibonacci(i+1)+ Math.Sqrt(Fibonacci(2 * i + 2));
                perimeter = (side1 + side2 + side3)*(-side1 + side2 + side3)*(side1 - side2 + side3)*(side1 + side2 - side3);
                area = Math.Sqrt(perimeter)/4;
                Console.WriteLine(area);
            }
            Console.ReadLine();
        }
        static double Fibonacci(int index)
        {
        double p = (1 + Math.Sqrt(5)) / 2;
            return (Math.Pow(p, index) - Math.Pow(-p, -index)) / Math.Sqrt(5);
        }
}          
}
