//Monday 9th October 2023
//#19 Counting Sundays
//1 Jan 1900 was a Monday.
//A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
//How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEProject19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //maybe we can make an array for every day, assigning each a value between 1 and 6
            //since the only century is 2000, and it's divisible by 400, they are all leap years so we dont have to count the exception

            //averagely there should be 171 Sundays//
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int currentDay = 1; //1st Jan 1901 was a Tueday
            int sundayCount = 0;
            for (int year = 1901; year < 2001; year++)
            {
                for (int month = 1; month < 13; month++)
                {
                    currentDay = (currentDay + WhatMonthsIsIt(month, year)) % 7;
                    if (currentDay==0)
                    {
                        currentDay = 7;
                    }
                    if (week[currentDay-1] == "Sunday")
                    {
                        sundayCount += 1;
                        Console.WriteLine(week[currentDay] + " " + month + " " + year);
                    }
                }
            }
            Console.WriteLine(sundayCount);
            Console.ReadLine();
        }
        static int WhatMonthsIsIt(int month, int year)
        {
            if (year % 4 == 0 && month == 2) //acount for Leap Years first
            {
               return 29;               
            }
            if (month == 2)
            {
                return 28;
            }
            if (month == 9 || month == 4 || month == 6 || month == 11) //30 days in September, April, June and November
            {
                return 20;
            }
            return 31;
        }
    }
}
