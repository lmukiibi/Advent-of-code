using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Days
{
    class Day5
    {
        //Template Class
        private string path = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 5.txt";
        private string importedString;

        List<string> listOfValues;
        List<int> listOfSeatIDs;
        List<int> missingSeats;
        public Day5()
        {
            listOfValues = new List<string>();
            importedString = Import_Class.ImportFile(path);
            listOfValues = Logics_Class.StringToList(importedString);
            listOfSeatIDs = new List<int>();
            listOfSeatIDs = Logics_Class.CalculateSeatIDs(listOfValues);
            missingSeats = new List<int>();

        }

        public void Run()
        {
            int highest = 0;
            foreach (int i in listOfSeatIDs)
            {
                if (i > highest)
                    highest = i;
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine($"The highest seat number is {highest}");
            missingSeats = Logics_Class.FindSeat(listOfSeatIDs);
            foreach (int i in missingSeats)
            {
                Console.WriteLine(i.ToString());
            }


            
            Console.ReadKey();
        }
    }
}
