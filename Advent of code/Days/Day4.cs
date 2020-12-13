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
        public Day4()
        {
            importedString = Import_Class.ImportFile(path);
            listOfValues = new List<string>();
        }

        public void Run()
        {
            myPassports = Logics_Class.StringOfBlocksToList(importedString);

            WriteAllPassports(myPassports);
            
            //Console.WriteLine(importedString);
            Console.ReadKey();
        }

        private void WriteAllPassports(List<Passport> pass)
        {
            foreach (Passport p in pass)
            {
                Console.WriteLine($"{p.Byr} {p.Cid} {p.Ecl} {p.Eyr} {p.Hcl} {p.Hgt} {p.Iyr} {p.Pid}\n");
            }
        }
    }
}
//Devide the key:values into BLOCKS likea class, divide the list