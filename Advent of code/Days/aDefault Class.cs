using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Days
{
    class aDefault_Class
    {
        //Template Class
        private string path = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 2.txt";
        private string importedString;
        public aDefault_Class()
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
