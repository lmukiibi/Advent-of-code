using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code
{
    static class Logics_Class
    {
        public static List<string> StringToList(string s)
        {
            string buffer = "";
            List<string> listOfStrings = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() != "\n")
                    buffer += s[i];
                else
                {
                    listOfStrings.Add(buffer);
                    buffer = "";
                }
            }
            return listOfStrings;

        }

        public static List<int> ListOfStringsToListOfInts(List<string> list)
        {
            List<int> buffer = new List<int>();
            foreach (String s in list)
                buffer.Add(Convert.ToInt32(s));
            return buffer;
        }

        public static int FindSumOfTwoValuesOfInt(List<int> list, int targetSum)
        {
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list.Count; j++)
                    if (list[i] + list[j] == targetSum)
                        // i = 36 - j = 147
                        return list[i] + list[j];
            return 0;

        }
        public static int FindSumOfThreeValuesOfInt(List<int> list, int targetSum)
        {
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list.Count; j++)
                    for (int k = 0; k < list.Count; k++)
                    if (list[i] + list[j] + list[k] == targetSum)
                        // i = 33 - j = 69 - k = 90
                        return list[i] + list[j] + list[k];
            return 0;

        }
    }
}
