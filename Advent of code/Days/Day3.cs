using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code.Days
{
    class Day3
    {
        private string path = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 3.txt";
        private string path2 = @"C:\Users\123\source\repos\Advent of code\Input codes\input day 31.txt";
        private string importedString;

        private char[,] twoDArr;
        List<string> listOfValues;

        private int[,] paths;
        private int[] sumOfPaths;

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

            sumOfPaths = new int[5];
        }

        public void Run()
        {
            int y = 0, x = 0, count;
            double sum;
            //Console.WriteLine(importedString);
            twoDArr = Logics_Class.ExtendTheMap(listOfValues, listOfValues.Count, listOfValues[0].Length);

            y = twoDArr.Length;
            x = listOfValues[0].Length;
            
            //This counts all the slopepaths
            for (int i = 0; i < 5; i++)
            {
                twoDArr = Logics_Class.CalculateNumberOfTreeHits(twoDArr, listOfValues.Count, listOfValues[0].Length * 100,
                    out count, paths[i, 0], paths[i, 1]);
                Console.WriteLine($"You hit {count} trees.");
                sumOfPaths[i] = count;
            }
            sum = sumOfPaths[0];
            for (int i = 1; i < sumOfPaths.Length; i++)
                sum *= sumOfPaths[i];
            Console.WriteLine($"All the trees hit with different paths multiplied is {sum}.");
            
            /* This only counts one path
            twoDArr = Logics_Class.CalculateNumberOfTreeHits(twoDArr, listOfValues.Count, listOfValues[0].Length * 100,
                out count, paths[4, 0], paths[4, 1]);
            Console.WriteLine($"You hit {count} trees.");

            
            //This code is to make us view if we did it correct
            using (StreamWriter sw = new StreamWriter(path2))
            {
                for (int i = 0; i < listOfValues.Count; i++)
                {
                    for (int j = 0; j < listOfValues[0].Length * 6; j++)
                    {
                        sw.Write($"{twoDArr[i, j]}");
                    }
                    sw.Write("\n");
                }
            }
            */
            
            

            Console.ReadKey();
        }
    }
}
