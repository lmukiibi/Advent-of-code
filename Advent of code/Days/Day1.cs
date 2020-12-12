using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Days
{
    class Day1
    {
        private string path = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 1.txt";
        private string importedString;

        List<int> listOfValues;
        public Day1()
        {
            importedString = Import_Class.ImportFile(path);
            listOfValues = new List<int>();
            listOfValues = Logics_Class.ListOfStringsToListOfInts(Logics_Class.StringToList(importedString));
        }

        public void Run()
        {
            Console.WriteLine(importedString + "\n");
            int sum = Logics_Class.FindSumOfTwoValuesOfInt(listOfValues, 2020);
            Console.WriteLine(sum.ToString());
            Console.WriteLine($"The sum of {listOfValues[36]} and {listOfValues[147]} is {sum}.\n" +
                $"Multyply them and you get {listOfValues[36] * listOfValues[147]}.");

            sum = Logics_Class.FindSumOfThreeValuesOfInt(listOfValues, 2020);
            Console.WriteLine(sum.ToString());
            Console.WriteLine($"The sum of {listOfValues[33]}, {listOfValues[69]} and {listOfValues[90]} is {sum}.\n" +
                $"Multyply them and you get {listOfValues[33] * listOfValues[69] * listOfValues[90]}.");
            Console.ReadKey();
        }
    }
}
