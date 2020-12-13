using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code
{
    class Passport
    {
        private string byr;
        private string iyr;
        private string eyr;
        private string hgt;
        private string hcl;
        private string ecl;
        private string pid;
        private string cid;

        public Passport (string pass)
        {
            ReadAndSplitLine(pass);
        }

        private void ReadAndSplitLine(string pass)
        {
            string[] temp = pass.Split(' ');
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Contains("byr"))
                    byr = temp[i];
                else if (temp[i].Contains("iyr"))
                    iyr = temp[i];
                else if (temp[i].Contains("eyr"))
                    eyr = temp[i];
                else if (temp[i].Contains("hgt"))
                    hgt = temp[i];
                else if (temp[i].Contains("hcl"))
                    hcl = temp[i];
                else if (temp[i].Contains("ecl"))
                    ecl = temp[i];
                else if (temp[i].Contains("pid"))
                    pid = temp[i];
                else if (temp[i].Contains("cid"))
                    cid = temp[i];
            }

        }

        public string Byr { get => byr; }
        public string Iyr { get => iyr; }
        public string Eyr { get => eyr; }
        public string Hgt { get => hgt; }
        public string Hcl { get => hcl; }
        public string Ecl { get => ecl; }
        public string Pid { get => pid; }
        public string Cid { get => cid; }

    }
}
