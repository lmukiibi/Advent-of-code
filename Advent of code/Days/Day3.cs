using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Days
{
    class Day3
    {
        private string path = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 3.txt";
        private string importedString;
        public Day3()
        {
            importedString = Import_Class.ImportFile(path);
        }

        public void Run()
        {
            Console.WriteLine(importedString);
            Console.ReadKey();
        }
    }
}
