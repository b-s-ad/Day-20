using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg  // UC 2
{
    class Patterns // Regex UC 2    
    {
        public static string Regexx = "^[A-Z][a-z]{2}[ ]([A-Z][a-z]{2})$";

        public bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

