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
            WriteLine("\n07.Default Input : abc@1.com\n");
            WriteLine(patterns.regex("abc@1.com"));
            ReadLine();
        }

    }
}