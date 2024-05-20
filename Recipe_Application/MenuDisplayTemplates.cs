using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Recipe_Application
{
    internal class MenuDisplayTemplates
    {

        public static void printLineSeperator()
        {
            Console.WriteLine("------------------------------------------------------------------");
        }

        //creates main menu
        public static void createMainMenu()
        {
            printLineSeperator();
            Console.WriteLine(RecipeConstants.MENU_HEADING);
            printLineSeperator();
            Console.WriteLine(RecipeConstants.MAIN_MENU);
        }
    }
}
