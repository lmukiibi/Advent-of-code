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

        List<Passport> myPassports;

        List<string> listOfValues;

        int count;
        public Day4()
        {
            importedString = Import_Class.ImportFile(path);
            listOfValues = new List<string>();
        }

        public void Run()
        {
            myPassports = Logics_Class.StringOfBlocksToList(importedString);

            //WriteAllPassports(myPassports);

            count = Logics_Class.CheckValidPassports(myPassports);
            Console.WriteLine($"{count} valid passports.");
            foreach (Passport p in myPassports)
            {
                if (p.Valid)
                {
                    for (int i = 0; i < p.KEYS.Length; i++)
                        try
                        {
                            Console.Write($"{p.MyPassport[p.KEYS[i]]} ");
                        }
                        catch (Exception e) { }
                    Console.WriteLine("");
                }
            }
            //Console.WriteLine(importedString);
            Console.ReadKey();
        }

        

        private void WriteAllPassports(List<Passport> pass)
        {
            foreach (Passport p in pass)
            {
                for (int i = 0; i < p.KEYS.Length; i++)
                    try
                    {
                        Console.Write($"{p.MyPassport[p.KEYS[i]]}\t");
                    }
                    catch (Exception e) { Console.Write("       \t"); };
                Console.WriteLine("");
            }
        }
    }
}
//Devide the key:values into BLOCKS likea class, divide the list