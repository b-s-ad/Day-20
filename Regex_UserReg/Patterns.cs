using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg  // UC 5
{
    class Patterns // Regex UC 5    
    {
        public static string Regexx = @"^(?=.*[A-Za-z])(?=.*\w)[A-Za-z\w]{8}$";

        public bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

