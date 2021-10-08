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
            WriteLine("\n01.Default Input : abc@yahoo.com \n");
            WriteLine(patterns.regex("abc@yahoo.com"));
            ReadLine();
        }

    }
}