using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg  // UC 1
{
    class Patterns // Regex UC 1    
    {
        public static string Regexx = @"^([A-Z][\w]{2})*$";

        public bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

