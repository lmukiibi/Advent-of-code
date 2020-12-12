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

        private char[,] twoDArr;
        List<string> listOfValues;

        private int[,] paths;

        public Day3()
        {
            importedString = Import_Class.ImportFile(path);

            listOfValues = Logics_Class.StringToList(importedString);
            paths = new int[5, 2];
            paths[0, 0] = 1; paths[0, 1] = 1;
            paths[1, 0] = 3; paths[1, 1] = 1;
            paths[2, 0] = 5; paths[2, 1] = 1;
            paths[3, 0] = 7; paths[3, 1] = 1;
            paths[4, 0] = 1; paths[4, 1] = 2;
        }

        public void Run()
        {
            int y = 0, x = 0, count, sum = 0;
            //Console.WriteLine(importedString);
            twoDArr = Logics_Class.ExtendTheMap(listOfValues, listOfValues.Count, listOfValues[0].Length);

            //twoDArr = Logics_Class.ListOfStringsTo2DArray(listOfValues);

            y = twoDArr.Length;
            x = listOfValues[0].Length;
            
            for (int i = 0; i < 5; i++)
            {
                twoDArr = Logics_Class.CalculateNumberOfTreeHits(twoDArr, listOfValues.Count, listOfValues[0].Length * 100,
                    out count, paths[i, 0], paths[i, 1]);
                Console.WriteLine($"You hit {count} trees.");
                sum *= count;
            }
            Console.WriteLine($"All the trees hit with different paths multiplied is {sum}.");
            /*
            twoDArr = Logics_Class.CalculateNumberOfTreeHits(twoDArr, listOfValues.Count, listOfValues[0].Length * 100,
                out count, paths[3, 0], paths[3, 1]);
            Console.WriteLine($"You hit {count} trees.");
            */

            //This code is to make us view if we did it correct
            /*
            for (int i = 0; i < listOfValues.Count; i++)
            {
                for (int j = 0; j < listOfValues[0].Length * 2; j++)
                {
                   Console.Write($"{twoDArr[i, j]}");
                }
                Console.WriteLine("");
            }
            */
            

            Console.ReadKey();
        }
    }
}
