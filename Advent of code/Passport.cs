﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code
{
    class Passport
    {
        public string[] KEYS = new string[] { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid", "cid" };
        public string[] eyeColor = new string[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
        private Dictionary<string, string> byr;
        private Dictionary<string, string> iyr;
        private Dictionary<string, string> eyr;
        private Dictionary<string, string> hgt;
        private Dictionary<string, string> hcl;
        private Dictionary<string, string> ecl;
        private Dictionary<string, string> pid;
        private Dictionary<string, string> cid;
        private Dictionary<string, string> myDictionary;

        private bool valid;

        private List<string> missingKEYS;

        public Passport (string pass)
        {
            byr = new Dictionary<string, string>();
            iyr = new Dictionary<string, string>();
            eyr = new Dictionary<string, string>();
            hgt = new Dictionary<string, string>();
            hcl = new Dictionary<string, string>();
            ecl = new Dictionary<string, string>();
            pid = new Dictionary<string, string>();
            cid = new Dictionary<string, string>();

            myDictionary = new Dictionary<string, string>();

            missingKEYS = new List<string>();

            valid = false;

            ReadAndSplitLine(pass);

            CheckValidity();
        }
        public List<string> MissingKeys { get => missingKEYS; }
        public bool Valid { get => valid; }
        public Dictionary<string, string> MyPassport { get => myDictionary; }
        public Dictionary<string, string> Byr { get => byr; }
        public Dictionary<string, string> Iyr { get => iyr; }
        public Dictionary<string, string> Eyr { get => eyr; }
        public Dictionary<string, string> Hgt { get => hgt; }
        public Dictionary<string, string> Hcl { get => hcl; }
        public Dictionary<string, string> Ecl { get => ecl; }
        public Dictionary<string, string> Pid { get => pid; }
        public Dictionary<string, string> Cid { get => cid; }

        private void ReadAndSplitLine(string pass)
        {
            string[] temp = pass.Split(' ');
            string[] temp2 = null;
            for (int i = 0; i < temp.Length; i++)
            {
                temp2 = temp[i].Split(':');
                if (temp[i].Contains("byr"))
                    myDictionary.Add(temp2[0], temp2[1]);
                else if (temp[i].Contains("iyr"))
                    myDictionary.Add(temp2[0], temp2[1]);
                else if (temp[i].Contains("eyr"))
                    myDictionary.Add(temp2[0], temp2[1]);
                else if (temp[i].Contains("hgt"))
                    myDictionary.Add(temp2[0], temp2[1]);
                else if (temp[i].Contains("hcl"))
                    myDictionary.Add(temp2[0], temp2[1]);
                else if (temp[i].Contains("ecl"))
                    myDictionary.Add(temp2[0], temp2[1]);
                else if (temp[i].Contains("pid"))
                    myDictionary.Add(temp2[0], temp2[1]);
                else if (temp[i].Contains("cid"))
                    myDictionary.Add(temp2[0], temp2[1]);
            }

        }

        private void CheckValidity()
        {
            int count = 0;
            for (int i = 0; i < KEYS.Length; i++)
            {
                try
                {
                    if (myDictionary[KEYS[i]] != null)
                        count++;
                }
                catch (Exception e) { missingKEYS.Add(KEYS[i]); }
            }

            //This is for part 1
            //if (count == KEYS.Length)
            //    valid = true;
            if (missingKEYS.Count == 1 && missingKEYS[0] == "cid")
                valid = CheckOtherParameters();
            else if (missingKEYS.Count == 0)
                valid = CheckOtherParameters();
        }

        private bool CheckOtherParameters()
        {
            string charactersAllowed = "0123456789abcdef#";
            int iTemp = 0;
            string sTemp = "";
            if (myDictionary["byr"].Length == 4)
            {
                iTemp = Convert.ToInt32(myDictionary["byr"]);
                if (iTemp > 1919 && iTemp < 2003)
                {
                    if (myDictionary["iyr"].Length == 4)
                    {
                        iTemp = Convert.ToInt32(myDictionary["iyr"]);
                        if (iTemp > 2009 && iTemp <2021)
                        {
                            if (myDictionary["eyr"].Length == 4)
                            {
                                iTemp = Convert.ToInt32(myDictionary["eyr"]);
                                if (iTemp > 2019 && iTemp < 2031)
                                {
                                    if (myDictionary["hgt"].Contains("cm"))
                                    {
                                        if (myDictionary["hgt"].Length == 5)
                                        {
                                            sTemp = myDictionary["hgt"][0].ToString();
                                            sTemp += myDictionary["hgt"][1];
                                            sTemp += myDictionary["hgt"][2];
                                            iTemp = Convert.ToInt32(sTemp);
                                            if (iTemp > 149 && iTemp < 194)
                                            {
                                                if (myDictionary["hcl"].Length == 7)
                                                {
                                                    sTemp = myDictionary["hcl"];
                                                    if (sTemp[0] == '#')
                                                    {
                                                        for (int i = 0; i < sTemp.Length; i++)
                                                        {
                                                            if (!charactersAllowed.Contains(sTemp[i]))
                                                                break;
                                                        }
                                                        foreach (String eye in eyeColor)
                                                        {
                                                            if (myDictionary["ecl"] == eye)
                                                            {
                                                                if (myDictionary["pid"].Length == 9)
                                                                {
                                                                    return true;
                                                                }
                                                            }
                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                    else if (myDictionary["hgt"].Contains("in"))
                                    {
                                        if (myDictionary["hgt"].Length == 4)
                                        {
                                            sTemp = myDictionary["hgt"][0].ToString();
                                            sTemp += myDictionary["hgt"][1];
                                            iTemp = Convert.ToInt32(sTemp);
                                            if (iTemp > 58 && iTemp < 77)
                                            {
                                                if (myDictionary["hcl"].Length == 7)
                                                {
                                                    sTemp = myDictionary["hcl"];
                                                    if (sTemp[0] == '#')
                                                    {
                                                        for (int i = 0; i < sTemp.Length; i++)
                                                        {
                                                            if (!charactersAllowed.Contains(sTemp[i]))
                                                                break;
                                                        }
                                                        foreach (String eye in eyeColor)
                                                        {
                                                            if (myDictionary["ecl"] == eye)
                                                            {
                                                                if (myDictionary["pid"].Length == 9)
                                                                {
                                                                    return true;
                                                                }
                                                            }
                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

    }
}
