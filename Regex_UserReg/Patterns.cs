using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg  // UC 6
{
    class Patterns // Regex UC 6    
    {
        public static string Regexx = "^[a-z]{7}[A-Z]$";

        public bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

