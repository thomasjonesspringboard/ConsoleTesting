using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace ConsoleTesting
{
    internal class StringReplacer
    {
        //Class1() { }
        public static List<string> StripWhitespace(List<string> liststr)
        {
            var re = new Regex(@"\s+");
            var returnlist = from str in liststr select re.Replace(str, "");
            return (from str in liststr select re.Replace(str, "")).ToList();

        }
        
    }
}
