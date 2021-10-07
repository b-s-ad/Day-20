using System;
using static System.Console;

namespace Regex_UserReg
{
    class Program // Regex UC 8
    {
       
        static void Main(string[] args)
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();

            Patterns patterns = new Patterns();
            
            WriteLine("\nDefault Value : A2b@c-dEf\n");
                
            WriteLine(patterns.regex("A2b@c-dEf"));
            
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

