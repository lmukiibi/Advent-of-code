using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Days
{
    class Day4
    {
        //Template Class
        private string path = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 4.txt";
        private string importedString;

        List<string> listOfValues;
        public Day4()
        {
            importedString = Import_Class.ImportFile(path);
            listOfValues = new List<string>();
        }

        public void Run()
        {
            listOfValues = Logics_Class.StringOfBlocksToList(importedString);
            Console.WriteLine(importedString);
            Console.ReadKey();
        }
    }
}
