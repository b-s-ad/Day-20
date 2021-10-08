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
            WriteLine("\n06.Default Input : abc.100@abc.com.au\n");
            WriteLine(patterns.regex("abc.100@abc.com.au"));
            ReadLine();
        }

    }
}