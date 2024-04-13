using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4_23
{
    public class FileNameExtractor
    {
        public string ExtractFileNameWithExtension(string fullPath)
        {
            string pattern = @"[^\\\/]*\.[^\\\/.]*$";

            Match match = Regex.Match(fullPath, pattern);
            if (match.Success)
            {
                return match.Value;
            }
            else
            {
                return "Nothing";
            }
        }
    }
}
