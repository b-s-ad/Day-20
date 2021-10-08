using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg   // Regex UC 9 VE8
{
    public class Patterns   
    {
        public static string Regexx = "^[a-zA-z]+[@}+[a-zA-Z]+[.][a-zA-Z]{2,3}[.][a-zA-z]{2,3}$";

        public  bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

