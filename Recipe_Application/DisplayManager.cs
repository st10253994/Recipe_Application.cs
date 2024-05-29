using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    internal class DisplayManager
    {
        private RecipeManager recipeManager;
        private int choice = 0;
        
        

        private DisplayManager()
        {
            //private constructor to prevent default constructor 
        }

        public DisplayManager(RecipeManager recipeManager)
        {
            this.recipeManager = recipeManager;
        }

        //displays main menu
        public void displayMainMenu()
        {
            while (choice != 8)
            {
                Console.Clear();
                MenuDisplayTemplates.createMainMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                displayMenuForIndex(choice);

            }
            
        }

        //adds a recipe
        public void addNewRecipe()
        {
            try
            {
                Console.Clear();
                Console.Write(RecipeConstants.RECIPE_NAME);
                string recipeName = Console.ReadLine();
                int index = recipeManager.addBasicRecipe(recipeName);


                Console.Write(RecipeConstants.NUMBER_OF_INGREDIENTS);
                int numberOfIngredients = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberOfIngredients; i++)
                {
                    Console.Write(RecipeConstants.INGREDIENT_NAME);
                    string ingredientName = Console.ReadLine();
                    Console.Write(RecipeConstants.QUANTITY);
                    double quantity = Convert.ToDouble(Console.ReadLine());
                    Console.Write(RecipeConstants.UNIT_OF_MEASURE);
                    string unitOfMeasure = Console.ReadLine();
                    Console.Write(RecipeConstants.CALORIE);
                    int calories = Convert.ToInt32(Console.ReadLine());
                    Console.Write(RecipeConstants.FOOD_GROUP);
                    string foodGroup = Console.ReadLine();
                    recipeManager.createNewIngredient(index, ingredientName, quantity, unitOfMeasure, calories, foodGroup);
                }

                Console.Write(RecipeConstants.NUMBER_OF_STEPS);
                int numberOfSteps = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numberOfSteps; i++)
                {
                    Console.Write("Step " + (i + 1) + ": ");
                    string stepDescription = Console.ReadLine();
                    recipeManager.createNewStep(index, stepDescription);
                }
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                displayContinueMessage();
            }

        }

        //creates a list recipe names in alphabetic order
        public void displayAllRecipeNames()
        {
            Console.Clear();
            RecipeDisplayTemplates.createListOfRecipes(recipeManager.Recipes, true);
        }

        //displays the list of recipe names
        private void displayAllRecipesSelection()
        {
            displayAllRecipeNames();
            displayContinueMessage();
        }

        //creats the recipe details for a recipe an index
        public void displayRecipeForIndex(int index)
        {
            RecipeDisplayTemplates.createRecipeDetails(recipeManager.Recipes[index - 1]);
        }

        //displays the recipe details at the given index
        private void displayRecipeSpecific()
        {
            displayAllRecipeNames();
            Console.Write(RecipeConstants.SELECT_RECIPE);
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            displayRecipeForIndex(index);
            displayContinueMessage();
        }

        //just prevents the program from running through a display function
        private void displayContinueMessage()
        {
            string input;
            Console.Write(RecipeConstants.CONTINUE_MESSAGE);
            input = Console.ReadLine();
            if(input == "")
            {
                displayMenuForIndex(0);
            }

        }

        //displays the recipes and provides the option to scale the given recipe
        private void displayRecipeScaleSelection()
        {
            try
            {
                displayAllRecipeNames();
                Console.Write(RecipeConstants.SELECT_RECIPE);
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write(RecipeConstants.SCALE_FACTOR);
                double factor = Convert.ToDouble(Console.ReadLine());
                recipeManager.scaleRecipeByFactor(index, factor);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                displayContinueMessage();
            }
        }

        //resets the scaled recipe
        private void displayResetScaleFactor()
        {
            try
            {
                displayAllRecipeNames();
                Console.Write(RecipeConstants.SELECT_RECIPE);
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                recipeManager.resetRecipeScaleFactor(index);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                displayContinueMessage();
            }
        }

        //removes a recipe at a given index
        private void displayRemoveRecipeSelection()
        {
            try
            {
                displayAllRecipeNames();
                Console.Write(RecipeConstants.DELETE_RECIPE);
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                recipeManager.removeRecipeSelectionByIndex(index);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                displayContinueMessage();
            }
        }

        //displays the total calories for a selected recipe
        private void displayTotalCalorieCountSelection()
        {
            try
            {
                displayAllRecipeNames();
                Console.Write(RecipeConstants.SELECT_RECIPE);
                int index = Convert.ToInt32(Console.ReadLine()) - 1;
                int totalCalories = recipeManager.getCalorieCountForRecipeByIndex(index);
                Console.Clear();
                RecipeDisplayTemplates.createTotalCalories(totalCalories);
                if (totalCalories > 300)
                {
                    print(RecipeConstants.DELEGATE_MESSAGE);
                }
                Console.Write(RecipeConstants.NEXT_LINE);
                displayContinueMessage();
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                displayContinueMessage();
            }
        }

        delegate void PrintWanringMessage(string message);

        PrintWanringMessage print = (message) =>
        {
            Console.WriteLine(message);

        };

        //displays the main menu
        private void displayMenuForIndex(int choice)
        {
            Console.Clear ();
            switch (choice)
            {
                case 1: addNewRecipe(); break;
                case 2: displayRecipeSpecific(); break;
                case 3: displayRecipeScaleSelection(); break;
                case 4: displayResetScaleFactor(); break;
                case 5: displayRemoveRecipeSelection(); break;
                case 6: displayAllRecipesSelection(); break;
                case 7: displayTotalCalorieCountSelection(); break;
                case 8: Environment.Exit(0); break;
                default: displayMainMenu(); break;
            }
        }
    }
}
