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
    }
}


