/*using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Regex_UserReg  // UC 8
{
    public class Patterns // Regex UC 8    
    {
        public static string Regexx = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\w\s]).{8,}$"; 

        public  bool regex(string regex)
        {
            return Regex.IsMatch(regex, Regexx);
        }
    }

}

*/