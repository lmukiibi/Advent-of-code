using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code
{
    static class Import_Class
    {
        public static string ImportFile(string path)
        {
            using (StreamReader streamReadder = File.OpenText(path))
            {
                return streamReadder.ReadToEnd();
            }
        }
    }
}
