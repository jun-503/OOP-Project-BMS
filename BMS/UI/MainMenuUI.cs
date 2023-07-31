using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.UI
{
    class MainMenuUI
    {
        public static void printHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("                       ************************************************** "                        );
            Console.WriteLine("                       **            Bank Management System            ** "                        );
            Console.WriteLine("                       ************************************************** "                        );
            Console.ResetColor();
            Console.WriteLine();
        }
       public static int mainMenu()
        {
            int op;
            Console.WriteLine("Press 1 to SignIn:");
            Console.WriteLine("Press 2 to SignUp: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press 9 to Exit:");
            Console.ResetColor();
            Console.Write("Enter Option: ");
            op = int.Parse(Console.ReadLine());
            return op;
        }

       public static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
