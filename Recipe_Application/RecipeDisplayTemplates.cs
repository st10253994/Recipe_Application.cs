using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    internal class RecipeDisplayTemplates
    {
        //method to create a new recipe details instance
        public static void createRecipeDetails(Recipe recipe)
        {
            List<Ingredient> ingredients = recipe.Ingredients;

            printLineSeperator();
            Console.WriteLine(RecipeConstants.RECIPE_NAME + recipe.Name);
            printLineSeperator();
            Console.WriteLine(RecipeConstants.INGREDIENT_LIST_FORMAT);
            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine((i + 1) +
                    ".  " + ingredients[i].Name +
                    " " + (ingredients[i].Quantity * recipe.QuantityFactorValue) +
                    " " + ingredients[i].UnitOfMeasure + "\n[" + (ingredients[i].Calories * recipe.QuantityFactorValue) + " " + RecipeConstants.CALORIE_UNIT + " " +
                    ingredients[i].FoodGroup + "]");
            }
            printLineSeperator();
            Console.WriteLine(RecipeConstants.STEP_LIST_FORMAT);
            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                Console.WriteLine((i + 1) + ".  " + recipe.Steps[i].Description);
            }
            printLineSeperator();
        }

        public static void printLineSeperator()
        {
            Console.WriteLine("------------------------------------------------------------------");
        }

        //creates a instance of a recipe list
        public static void createListOfRecipes(List<Recipe> recipes, Boolean alphabeticalOrder)
        {
            if (alphabeticalOrder)
            {
                recipes.Sort();
                printLineSeperator();
                Console.WriteLine(RecipeConstants.RECIPE);
                printLineSeperator();
                for (int i = 0;i < recipes.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + recipes[i].Name + RecipeConstants.NEXT_LINE);
                }
                printLineSeperator();
            }
        }

        //creates a total calorie count instance
        public static void createTotalCalories(int totalCalorieCount)
        {
            printLineSeperator();
            Console.WriteLine(RecipeConstants.TOTAL_CALORIES);
            printLineSeperator();
            Console.WriteLine(totalCalorieCount + RecipeConstants.CALORIE_UNIT);
            printLineSeperator();
        }

            
        
    }
}
