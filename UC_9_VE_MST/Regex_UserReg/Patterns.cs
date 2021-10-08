using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg   // Regex UC 9 VE7
{
    public class Patterns   
    {
        public static string Regexx = "^[a-zA-z]+[@]+[0-9]+[.][a-zA-Z]{2,3}$";

        public  bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

