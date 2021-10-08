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
            WriteLine("\n04.Default Input : abc111@abc.com \n");
            WriteLine(patterns.regex("abc111@abc.com"));
            ReadLine();
        }

    }
}