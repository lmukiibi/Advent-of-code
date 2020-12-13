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
            string temp = "";
            List<string> listOfStrings = new List<string>();
            List<string> returnList = new List<string>();
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
            listOfStrings.Add(buffer);
            foreach (String st in listOfStrings)
            {
                temp = "";
                for (int i = 0; i < st.Length; i++)
                {
                    if (s[i].ToString() != "\r")
                        temp += st[i];
                }
                returnList.Add(temp);
            }
            return returnList;

        }
        public static List<string> StringOfBlocksToList2(string impString)
        {
            List<Passport> listOfPassports = new List<Passport>();
            string buffer = "";
            string temp = "";
            List<string> listOfStrings = new List<string>();
            List<string> returnList = new List<string>();
            for (int i = 0; i < impString.Length; i++)
            {
                if (impString[i].ToString() != "\n")
                    buffer += impString[i];
                else
                {
                    listOfStrings.Add(buffer);
                    buffer = "";
                }
            }
            listOfStrings.Add(buffer);

            foreach (String s in listOfStrings)
            {
                if (s != "\r")
                {
                    temp += s;
                }
                else
                {
                    returnList.Add(temp);
                    temp = "";
                }
            }
            returnList.Add(temp);
            listOfStrings = null;
            listOfStrings = new List<string>();

            //This is supposed to remove the \r at the end of lines
            foreach (String s in returnList)
            {
                temp = "";
                for (int i = 0; i < s.Length; i++)
                {

                    if (s[i].ToString() != "\r")
                        temp += s[i];
                    else if (s[i].ToString() == "\r" && i != 0 && i != s.Length - 1)
                        temp += " ";

                }
                listOfStrings.Add(temp);
            }

            //foreach (String s in listOfStrings)
            //    listOfPassports.Add(new Passport(s));

            return listOfStrings;
            //return listOfPassports;

        }

        //Specific to passport
        public static List<Passport> StringOfBlocksToList(string impString)
        {
            List<Passport> listOfPassports = new List<Passport>();
            string buffer = "";
            string temp = "";
            List<string> listOfStrings = new List<string>();
            List<string> returnList = new List<string>();
            for (int i = 0; i < impString.Length; i++)
            {
                if (impString[i].ToString() != "\n")
                    buffer += impString[i];
                else
                {
                    listOfStrings.Add(buffer);
                    buffer = "";
                }
            }
            listOfStrings.Add(buffer);

            foreach (String s in listOfStrings)
            {
                if (s != "\r")
                {
                    temp += s;
                }
                else
                {
                    returnList.Add(temp);
                    temp = "";
                }
            }
            returnList.Add(temp);
            listOfStrings = null;
            listOfStrings = new List<string>();

            //This is supposed to remove the \r at the end of lines
            foreach (String s in returnList)
            {
                temp = "";
                for (int i = 0; i < s.Length; i++)
                {

                        if (s[i].ToString() != "\r")
                            temp += s[i];
                        else if (s[i].ToString() == "\r" && i != 0 && i != s.Length - 1)
                            temp += " ";

                }
                listOfStrings.Add(temp);
            }

            foreach (String s in listOfStrings)
                listOfPassports.Add(new Passport(s));
            //return returnList;
            return listOfPassports;

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

        //Splits each string into three categories
        public static int CheckForValidPassword(List<string> list, bool newCalc)
        {
            string range = "";
            string targetChar = "";
            string password = "";
            string buffer = "";

            int count = 0;

            List<string> temp = new List<string>();

            foreach (String pass in list)
            {
                range = targetChar = password = buffer = "";

                for (int i = 0; i < pass.Length; i++)
                {
                    if (pass[i].ToString() == " " && range == "")
                    {
                        range = buffer;
                        buffer = "";
                    }
                    else if (pass[i].ToString() == " " && targetChar == "")
                    {
                        targetChar = buffer[0].ToString();
                        buffer = "";
                    }

                    else if (pass[i].ToString() != "\r")
                        buffer += pass[i];
                }
                password = buffer;
                if (newCalc)
                {
                    if (CalculatePasswordPartTwo(range, targetChar, password))
                    {
                        count++;
                        temp.Add(pass);
                    }
                }
                else
                {
                    if (CalculatePassword(range, targetChar, password))
                        count++;
                }
            }
            //Calculation false gives 422
            //Calculation true gives 451
            return count;
        }

        //Returns true if the target is repeted within range
        private static bool CalculatePassword(string range, string target, string password)
        {
            int min = 0, max = 0, count = 0;
            string temp = "";

            //Get min and max range
            for (int i = 0; i < range.Length; i++)
            {
                if (range[i].ToString() != "-")
                    temp += range[i];
                else
                {
                    min = Convert.ToInt32(temp);
                    temp = "";
                }
            }
            max = Convert.ToInt32(temp);

            //Counts the amount the target charecter appears
            for (int i = 0; i < password.Length; i++)
                if (password[i].ToString() == target)
                    count++;
            if (count >= min && count <= max)
                return true;
            return false;
        }

        //returns true if target is at min or max once
        private static bool CalculatePasswordPartTwo(string range, string target, string password)
        {
            int min = 0, max = 0;
            string temp = "";

            //Get min and max range
            for (int i = 0; i < range.Length; i++)
                if (range[i].ToString() != "-")
                    temp += range[i];
                else
                {
                    min = Convert.ToInt32(temp);
                    temp = "";
                }
            max = Convert.ToInt32(temp);

            //Counts the amount the target charecter appears and it should only be once
            if (password[min - 1].ToString() == target ^ password[max - 1].ToString() == target)
                return true;
            return false;
        }

        public static char[,] ListOfStringsTo2DArray(List<string> list)
        {
            char[,] twoDarr = new char[list.Count, list[0].Length];
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list[0].Length; j++)
                    twoDarr[i, j] = list[i][j];
            return twoDarr;
        }

        public static char[,] CalculateNumberOfTreeHits(char[,] twoDArr, int y, int x, out int count, int r, int d)
        {
            int right = r, down = d, currentX = 0, currentY = 0;
            char xx = 'X', o = 'O', dot = '.', tree = '#';
            int tempCount = 0, rowCount = 0; 
            while (currentX < x && currentY < y)
            {
                if (twoDArr[currentY, currentX] == dot)
                    twoDArr[currentY, currentX] = o;
                else if (twoDArr[currentY, currentX] == tree)
                {
                    twoDArr[currentY, currentX] = xx;
                    tempCount++;
                }
                currentX += right;
                currentY += down;
                rowCount++;
            }
            //Console.WriteLine($"You hit {tempCount}");
            //We hit 187 trees
            Console.WriteLine("Rows" + rowCount.ToString());
            count = tempCount;
            return twoDArr;

        }

        public static char[,] ExtendTheMap(List<string> list, int y, int x)
        {
            int multiply = 300;
            char[,] bigMap = new char[y, x * multiply];
            int i = 0, rowCount = 0;
            string tempString = "";

            for (int j = 0; j < y; j++)
            {
                rowCount = j;
                i = 0;
                tempString = list[j];
                for (int k = 0; k < x * multiply; k++)
                {
                    if (i < tempString.Length)
                    {
                        bigMap[j, k] = tempString[i];
                        
                    }
                    else
                    {
                        i = 0;
                        bigMap[j, k] = tempString[i];
                    }
                    i++;
                }
            }
            return bigMap;
        }

        //Most of the logics are in Passport Class
        public static int CheckValidPassports(List<Passport> passports)
        {
            int count = 0;
            foreach (Passport p in passports)
            {
                if (p.Valid)
                    count++;
            }
            return count;
        }

        public static List<int> CalculateSeatIDs(List<string> list)
        {
            int[] steps = new int[] { 64, 32, 16, 8, 4, 2, 1, 4, 2, 1 };
            string sTemp = "";
            List<int> seatIDs = new List<int>();
            int row = 0, seat = 0;
            foreach (String str in list)
            {
                row = seat = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'B')
                        row += steps[i];
                    if (str[i] == 'R')
                        seat += steps[i];
                }
                seatIDs.Add(row * 8 + seat);
            }
            return seatIDs;
        }

        public static List<int> FindSeat(List<int> seatID)
        {
            List<int> missingSeats = new List<int>();
            List<int> freeSeats = new List<int>();
            bool exists = false;

            for (int i = 0; i < seatID.Count; i++)
                missingSeats.Add(-1);
            for (int i = 0; i < seatID.Count; i++)
            {
                if(seatID[i] < seatID.Count)
                missingSeats[seatID[i]] = 1;
            }



            for (int i = 0; i < missingSeats.Count; i++)
            {
                if (missingSeats[i] < 0)
                    freeSeats.Add(i);
            }

            return freeSeats;
        }

        public static List<int> GetNumberOfQuestionsAsked(List<string> list)
        {
            List<int> listOfQuestionsAnswered = new List<int>();
            string abc = "abcdefghijklmnopqrstuvwxyz";
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                count = 0;
                for (int j = 0; j < abc.Length; j++)
                {
                    if (list[i].Contains(abc[j].ToString()))
                        count++;
                }
                listOfQuestionsAnswered.Add(count);
            }

            /*This is for part 1
            for (int i = 0; i < list.Count; i++)
            {
                count = 0;
                for (int j = 0; j < abc.Length; j++)
                {
                    if (list[i].Contains(abc[j].ToString()))
                        count++;
                }
                listOfQuestionsAnswered.Add(count);
            }
            */


            return listOfQuestionsAnswered;
        }
    }


      
}
