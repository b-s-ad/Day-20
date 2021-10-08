using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg   // Regex UC 9 VE6
{
    public class Patterns   
    {
        public static string Regexx = "^[a-zA-z.0-9]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}[.][a-zA-z]{2,2}$";

        public  bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

