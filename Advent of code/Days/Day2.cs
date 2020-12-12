using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Days
{
    class Day2
    {
        private string path = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 2.txt";
        private string importedString;

        List<string> listOfValues;
        public Day2()
        {
            importedString = Import_Class.ImportFile(path);
            listOfValues = new List<string>();
            listOfValues = Logics_Class.StringToList(importedString);
        }

        public void Run()
        {
            int sum = Logics_Class.CheckForValidPassword(listOfValues, false);
            Console.WriteLine($"The number of valid passwords are {sum}.");
            sum = Logics_Class.CheckForValidPassword(listOfValues, true);
            Console.WriteLine($"The number of valid passwords with system two are {sum}.");
            Console.ReadKey();
        }
    }
}
