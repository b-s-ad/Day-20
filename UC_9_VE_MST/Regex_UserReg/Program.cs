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
            WriteLine("\n08.Default Input : abc@gmail.com.com\n");
            WriteLine(patterns.regex("aabc@gmail.com.com"));
            ReadLine();
        }

    }
}