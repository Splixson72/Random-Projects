﻿//Thursday 28th September 2023
//Project Euler 8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string LOOOOOONG = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            string tiny = "";
            Double highScore = 0; //our multiplication hits the integer limit and so cycles around, but will still remaiun negative; so the high score has to be ther lowest score        
            Double consecutiveTotal = 1;
            for (int i = 0; i < 1000 - 12; i++)
            {
                consecutiveTotal = 1;
                //consecutiveTotal = ((LOOOOOONG[i] - '0') * (LOOOOOONG[i + 1] - '0') * (LOOOOOONG[i + 2] - '0') * (LOOOOOONG[i + 3] - '0') * (LOOOOOONG[i + 4] - '0') * (LOOOOOONG[i + 5] - '0') * (LOOOOOONG[i + 6] - '0') * (LOOOOOONG[i + 7] - '0') * (LOOOOOONG[i + 8] - '0') * (LOOOOOONG[i + 9] - '0') * (LOOOOOONG[i + 10] - '0') * (LOOOOOONG[i + 11] - '0') * (LOOOOOONG[i + 12] - '0' ));
                tiny = LOOOOOONG.Substring(i, 13);
                //Console.WriteLine(Convert.ToDouble(LOOOOOONG.Substring(i, 13)));
                for (int j = 0; j <= 12; j++)
                {
                    consecutiveTotal *= tiny[j] - '0'; //Convert.ToInt64(tiny[j]);// - '0';
                }
                //Console.WriteLine(consecutiveTotal + " ^");
                if (highScore < consecutiveTotal) //& consecutiveTotal < 0)
                {
                    highScore = consecutiveTotal;
                    Console.WriteLine(highScore);
                    //Console.WriteLine(Convert.ToDouble(LOOOOOONG.Substring(i, 13)));
                    //Console.WriteLine((LOOOOOONG[i] - '0') +" "+ (LOOOOOONG[i + 1] - '0') +" "+ (LOOOOOONG[i + 2] - '0') +" "+ (LOOOOOONG[i + 3] - '0') +" "+ (LOOOOOONG[i + 4] - '0') +" "+ (LOOOOOONG[i + 5] - '0') +" "+ (LOOOOOONG[i + 6] - '0') +" "+ (LOOOOOONG[i + 7] - '0') +" "+ (LOOOOOONG[i + 8] - '0') +" "+ (LOOOOOONG[i + 9] - '0') +" "+ (LOOOOOONG[i + 10] - '0') +" "+ (LOOOOOONG[i + 11] - '0') +" "+ (LOOOOOONG[i + 12] - '0'));
                }
            }
            Console.WriteLine(highScore);
            Console.ReadLine();
        }
    }
}