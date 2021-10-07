using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg  // UC 4
{
    class Patterns // Regex UC 4    
    {
        public static string Regexx = "^[9][1][ ][1-9][0-9]{9}$";

        public bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

