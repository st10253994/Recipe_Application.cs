using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Application
{
    public class RecipeManager
    {

        private List<Recipe> recipes = [];

        // gets the recipe
        internal List<Recipe> Recipes
        { 
            get => recipes;
        }

        //Adds a new recipe instance
        public int addBasicRecipe(string recipeName)
        {
            Recipe recipe = new Recipe();
            recipe.Name = recipeName;
            recipes.Add(recipe);
            return recipes.Count - 1;
        }

        //Creates a single ingredient instance
        public void createNewIngredient(int recipeIndex, string ingredientName, double quantity, string unitOfMeasure, int calories, string foodGroup)
        {
            Recipe recipe = findRecipeByIndex(recipeIndex);
            if (recipe != null)
            {
                Ingredient ingredient = new Ingredient();
                ingredient.Name = ingredientName;
                ingredient.Quantity = quantity;
                ingredient.UnitOfMeasure = unitOfMeasure;
                ingredient.Calories = calories;
                ingredient.FoodGroup = foodGroup;
                recipe.Ingredients.Add(ingredient);
            }
        }

        //Creates a single step instance
        public void createNewStep(int recipeIndex, string stepDescription)
        {
            Recipe recipe = findRecipeByIndex(recipeIndex);
            if(recipe != null)
            {
                Step step = new Step();
                step.Description = stepDescription;
                recipe.Steps.Add(step);
            }
        }

        //finds recipe by index
        internal Recipe findRecipeByIndex(int index)
        {
            return recipes[index];
        }

        //Scales a recipe by a given facot
        public void scaleRecipeByFactor(int recipeIndex, double factor)
        {
            Recipe recipe = findRecipeByIndex(recipeIndex);
            recipe.QuantityFactorValue = factor;
        }

        //resets the quantityFactorValue for a recipe scaled at a given index
        public void resetRecipeScaleFactor(int index)
        {
            Recipe recipe = findRecipeByIndex(index);
            recipe.resetFactorValue();
        }

        //Deletes a recipes at a given index
        public void clearRecipeSelectionByIndex(int index)
        {
            Recipe recipe = findRecipeByIndex(index);
            recipes.Remove(recipe);
        }

        //Calculates the total amount of calories
        public int getCalorieCountForRecipeByIndex(int index)
        {
            int calorieTotal = 0;
            Recipe recipe = findRecipeByIndex(index);
            for (int i = 0;i < recipe.Ingredients.Count; i++)
            {
                calorieTotal += recipe.Ingredients[i].Calories;
            }
            return calorieTotal;
        }
    }
}
