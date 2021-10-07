using System;
using static System.Console;

namespace Regex_UserReg
{
    class Program // Regex UC 1 
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            
            WriteLine(patterns.validatePinCode("Abc2"));

            Console.ReadKey();
        }
    }
}