using Recipe_Application;
using System;
using System.Runtime.CompilerServices;

namespace main
{
    internal class program
    {
        static void Main(string[] args)
        {
            RecipeManager recipeManager = new RecipeManager();
            DisplayManager displayManager = new DisplayManager(recipeManager);

            displayManager.displayMainMenu();
        }
        /*
         * Feedback response:
            the feedabck outlined that the biggest problem within my previous version of the caode was structure and methods,
            I have addressed these issues in 2 ways:
            1) the structure is a lot more focused around using objects and they follow SOLID and DRY principles
            2) methods are created in a way to not be aware of what the program is doing but only be aware of its function
            By implementing these changes I have made a program that executes it function in a neat and effective manner.
        */
    }
}


