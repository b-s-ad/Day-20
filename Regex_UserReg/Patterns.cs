using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg  // UC 3
{
    class Patterns // Regex UC 3    
    {
        public static string Regexx = "^[a-z][-a-z0-9._]+@([-a-z0-9{2,2}]+[.])+[a-z]{2,2}$";

        public bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

