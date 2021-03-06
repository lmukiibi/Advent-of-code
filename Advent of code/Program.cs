﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent_of_code.Days;

namespace Advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Code");
            string code = Console.ReadLine();
            switch (code)
            {
                case "dayone":
                    Day1 day1 = new Day1();
                    day1.Run();
                    break;
                case "daytwo":
                    Day2 day2 = new Day2();
                    day2.Run();
                    break;
                case "daythree":
                    Day3 day3 = new Day3();
                    day3.Run();
                    break;
                case "dayfour":
                    Day4 day4 = new Day4();
                    day4.Run();
                    break;
                case "dayfive":
                    Day5 day5 = new Day5();
                    day5.Run();
                    break;
                case "daysix":
                    Day6 day6 = new Day6();
                    day6.Run();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
