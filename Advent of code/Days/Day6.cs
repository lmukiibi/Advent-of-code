using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Days
{
    class Day6
    {
        //Template Class
        private string path = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 6.txt";
        private string importedString;

        List<string> listOfValues;
        List<int> listOfAnswers;
        public Day6()
        {
            importedString = Import_Class.ImportFile(path);
            listOfValues = new List<string>();
            listOfValues = Logics_Class.StringOfBlocksToList2(importedString);
            listOfAnswers = new List<int>();
            listOfAnswers = Logics_Class.GetNumberOfQuestionsAsked(listOfValues);
        }

        public void Run()
        {
            int sum = 0;
            //Console.WriteLine(importedString);
            foreach (int i in listOfAnswers)
                sum += i;
                Console.WriteLine($"The sum of all questions with yes answers is {sum}.");
            Console.ReadKey();
        }
    }
}
