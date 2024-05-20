using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    internal class RecipeConstants
    {
        public const string MENU_HEADING = "Menu";
        public const string MAIN_MENU = "1. Add a new recipe\n2. Display a recipe\n3. Scale a recipe\n4. Reset a recipe scale\n5. Delete a recipe" + 
            "\n6. Display all recipes\n7. Display total calories for a recipe\n8. Exit\nInput:";
        public const string RECIPE = "Recipe: ";
        public const string INGREDIENT_LIST_FORMAT = "Ingredients: \n";
        public const string STEP_LIST_FORMAT = "Steps: \n";
        public const string NEXT_LINE = "\n";
        public const string TOTAL_CALORIES = "Total calories: ";
        public const string CALORIE_UNIT = "kcal";
        public const string ERROR_MESSAGE = "Unable to display the recipe details: ";
        public const string RECIPE_NAME = "Recipe name: ";
        public const string INGREDIENT_NAME = "Ingredient Name: " ;
        public const string QUANTITY = "Quantity: ";
        public const string UNIT_OF_MEASURE = "Unit of measure: ";
        public const string CALORIE = "Calories: ";
        public const string FOOD_GROUP = "Food group: ";
        public const string NUMBER_OF_INGREDIENTS = "How many ingredients will you be adding? ";
        public const string NUMBER_OF_STEPS = "How many steps will you be adding? ";
        public const string CONTINUE_MESSAGE = "Please press ENTER to continue: ";
        public const string SELECT_RECIPE = "Please select a recipe: ";
        public const string SCALE_FACTOR = "Please enter with what factor the recipe should scale: ";
        public const string DELETE_RECIPE = "Which recipe do you want to delete? ";
        public const string DELEGATE_MESSAGE = "The Recipe has exceeded 300 calories";
    }
}
