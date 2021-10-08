using System;
using static System.Console;

namespace Regex_UserReg
{
    class Program // Regex UC 9
    {

        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            WriteLine("Sample Valid Email\n\n");
            WriteLine("\n05.Default Input : abc-100@abc.net\n");
            WriteLine(patterns.regex("abc-100@abc.net"));
            ReadLine();
        }

    }
}