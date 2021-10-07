using System;
using static System.Console;

namespace Regex_UserReg
{
    class Program // Regex UC 4
    {
       
        static void Main(string[] args)
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();

            Patterns patterns = new Patterns();
            
            WriteLine("\nDefault Value : 91 9919819801\n");
            
            WriteLine(patterns.regex("91 9919819801"));
            
            WriteLine("\nEnter New Valid or Invalid  Input : \n");
            
            WriteLine(patterns.regex(ReadLine()));
            
            WriteLine("\nPress Enter To Type Value  || 0 = To Exit");


            string Menu;
            Menu = ReadLine();
            switch (Menu)
            {
                case "0":
                    System.Environment.Exit(1);
                    break;

                default:
                    WriteLine("");
                    break;
            }
            Mainmenu();
        }
    }
}

